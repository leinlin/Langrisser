using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200141D RID: 5149
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DrillUITask : LuaObject
{
	// Token: 0x0601D49F RID: 119967 RVA: 0x0093E568 File Offset: 0x0093C768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			DrillUITask o = new DrillUITask(name);
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

	// Token: 0x0601D4A0 RID: 119968 RVA: 0x0093E5BC File Offset: 0x0093C7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 1, out uiIntent);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			DrillUITask.StartUITask(uiIntent, techId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4A1 RID: 119969 RVA: 0x0093E614 File Offset: 0x0093C814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask.DrillUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4A2 RID: 119970 RVA: 0x0093E654 File Offset: 0x0093C854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool b = drillUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601D4A3 RID: 119971 RVA: 0x0093E6B0 File Offset: 0x0093C8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTotalSoldierInfoListWithFilter(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.SetTotalSoldierInfoListWithFilter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4A4 RID: 119972 RVA: 0x0093E704 File Offset: 0x0093C904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4A5 RID: 119973 RVA: 0x0093E758 File Offset: 0x0093C958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool b = drillUITask.m_luaExportHelper.IsNeedLoadStaticRes();
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

	// Token: 0x0601D4A6 RID: 119974 RVA: 0x0093E7B4 File Offset: 0x0093C9B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = drillUITask.m_luaExportHelper.CollectAllStaticResDescForLoad();
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

	// Token: 0x0601D4A7 RID: 119975 RVA: 0x0093E810 File Offset: 0x0093CA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4A8 RID: 119976 RVA: 0x0093E864 File Offset: 0x0093CA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4A9 RID: 119977 RVA: 0x0093E8B8 File Offset: 0x0093CAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4AA RID: 119978 RVA: 0x0093E90C File Offset: 0x0093CB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4AB RID: 119979 RVA: 0x0093E960 File Offset: 0x0093CB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PushAndPopLayerByState(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.PushAndPopLayerByState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4AC RID: 119980 RVA: 0x0093E9B4 File Offset: 0x0093CBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4AD RID: 119981 RVA: 0x0093EA08 File Offset: 0x0093CC08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillUIController_OnManualButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillUIController_OnManualButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4AE RID: 119982 RVA: 0x0093EA5C File Offset: 0x0093CC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillUIController_OnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int courseId;
			LuaObject.checkType(l, 2, out courseId);
			drillUITask.m_luaExportHelper.DrillUIController_OnTrainingButtonClick(courseId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4AF RID: 119983 RVA: 0x0093EAB8 File Offset: 0x0093CCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillUIController_OnAssistanceTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			drillUITask.m_luaExportHelper.DrillUIController_OnAssistanceTrainingButtonClick(slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B0 RID: 119984 RVA: 0x0093EB14 File Offset: 0x0093CD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillUIController_OnAssistanceStop(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			drillUITask.m_luaExportHelper.DrillUIController_OnAssistanceStop(taskId, slot, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B1 RID: 119985 RVA: 0x0093EB8C File Offset: 0x0093CD8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillUIController_OnAssistanceGetReward(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			drillUITask.m_luaExportHelper.DrillUIController_OnAssistanceGetReward(taskId, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B2 RID: 119986 RVA: 0x0093EBF8 File Offset: 0x0093CDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillSoldierManualUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillSoldierManualUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B3 RID: 119987 RVA: 0x0093EC4C File Offset: 0x0093CE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B4 RID: 119988 RVA: 0x0093ECA0 File Offset: 0x0093CEA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillSoldierManualUIController_OnNeedUpdateView(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int curPage;
			LuaObject.checkType(l, 2, out curPage);
			int rank;
			LuaObject.checkType(l, 3, out rank);
			ArmyTag armyTag;
			LuaObject.checkEnum<ArmyTag>(l, 4, out armyTag);
			drillUITask.m_luaExportHelper.DrillSoldierManualUIController_OnNeedUpdateView(curPage, rank, armyTag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B5 RID: 119989 RVA: 0x0093ED18 File Offset: 0x0093CF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillSoldierManualUIController_OnGoToTraingTech(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			drillUITask.m_luaExportHelper.DrillSoldierManualUIController_OnGoToTraingTech(techId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B6 RID: 119990 RVA: 0x0093ED74 File Offset: 0x0093CF74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTrainingUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillTrainingUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B7 RID: 119991 RVA: 0x0093EDC8 File Offset: 0x0093CFC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTrainingUIController_OnAddGold(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillTrainingUIController_OnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B8 RID: 119992 RVA: 0x0093EE1C File Offset: 0x0093D01C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTrainingUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillTrainingUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4B9 RID: 119993 RVA: 0x0093EE70 File Offset: 0x0093D070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTrainingUIController_OnTechLevelup(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			drillUITask.m_luaExportHelper.DrillTrainingUIController_OnTechLevelup(techId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4BA RID: 119994 RVA: 0x0093EEDC File Offset: 0x0093D0DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTrainingUIController_OnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			drillUITask.m_luaExportHelper.DrillTrainingUIController_OnEvolutionMaterialClick(goodsType, goodsId, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4BB RID: 119995 RVA: 0x0093EF54 File Offset: 0x0093D154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTrainingUIController_OnGotoGetPath(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 2, out getPath);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			drillUITask.m_luaExportHelper.DrillTrainingUIController_OnGotoGetPath(getPath, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4BC RID: 119996 RVA: 0x0093EFC0 File Offset: 0x0093D1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillTutorUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillTutorUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4BD RID: 119997 RVA: 0x0093F014 File Offset: 0x0093D214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTutorUIController_OnShowTutorHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.DrillTutorUIController_OnShowTutorHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4BE RID: 119998 RVA: 0x0093F068 File Offset: 0x0093D268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrillTutorUIController_OnConfirmAssistant(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			List<int> heroId;
			LuaObject.checkType<List<int>>(l, 3, out heroId);
			int workSeconds;
			LuaObject.checkType(l, 4, out workSeconds);
			int slot;
			LuaObject.checkType(l, 5, out slot);
			drillUITask.m_luaExportHelper.DrillTutorUIController_OnConfirmAssistant(taskId, heroId, workSeconds, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4BF RID: 119999 RVA: 0x0093F0EC File Offset: 0x0093D2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4C0 RID: 120000 RVA: 0x0093F140 File Offset: 0x0093D340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTimeText(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.UpdateTimeText();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4C1 RID: 120001 RVA: 0x0093F194 File Offset: 0x0093D394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = drillUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601D4C2 RID: 120002 RVA: 0x0093F1FC File Offset: 0x0093D3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4C3 RID: 120003 RVA: 0x0093F250 File Offset: 0x0093D450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4C4 RID: 120004 RVA: 0x0093F2A4 File Offset: 0x0093D4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = drillUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601D4C5 RID: 120005 RVA: 0x0093F30C File Offset: 0x0093D50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = drillUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601D4C6 RID: 120006 RVA: 0x0093F374 File Offset: 0x0093D574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			drillUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4C7 RID: 120007 RVA: 0x0093F3E0 File Offset: 0x0093D5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool b = drillUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601D4C8 RID: 120008 RVA: 0x0093F43C File Offset: 0x0093D63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			List<string> o = drillUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601D4C9 RID: 120009 RVA: 0x0093F498 File Offset: 0x0093D698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4CA RID: 120010 RVA: 0x0093F4EC File Offset: 0x0093D6EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4CB RID: 120011 RVA: 0x0093F540 File Offset: 0x0093D740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4CC RID: 120012 RVA: 0x0093F594 File Offset: 0x0093D794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4CD RID: 120013 RVA: 0x0093F5E8 File Offset: 0x0093D7E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4CE RID: 120014 RVA: 0x0093F63C File Offset: 0x0093D83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			drillUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4CF RID: 120015 RVA: 0x0093F698 File Offset: 0x0093D898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			drillUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4D0 RID: 120016 RVA: 0x0093F6F4 File Offset: 0x0093D8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			drillUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4D1 RID: 120017 RVA: 0x0093F750 File Offset: 0x0093D950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			drillUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4D2 RID: 120018 RVA: 0x0093F7AC File Offset: 0x0093D9AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool b = drillUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601D4D3 RID: 120019 RVA: 0x0093F808 File Offset: 0x0093DA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool b = drillUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601D4D4 RID: 120020 RVA: 0x0093F864 File Offset: 0x0093DA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool b = drillUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601D4D5 RID: 120021 RVA: 0x0093F8C0 File Offset: 0x0093DAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			UITaskBase o = drillUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601D4D6 RID: 120022 RVA: 0x0093F91C File Offset: 0x0093DB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4D7 RID: 120023 RVA: 0x0093F970 File Offset: 0x0093DB70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			drillUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4D8 RID: 120024 RVA: 0x0093F9C4 File Offset: 0x0093DBC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4D9 RID: 120025 RVA: 0x0093FA1C File Offset: 0x0093DC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			drillUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4DA RID: 120026 RVA: 0x0093FA78 File Offset: 0x0093DC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4DB RID: 120027 RVA: 0x0093FAD0 File Offset: 0x0093DCD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			drillUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4DC RID: 120028 RVA: 0x0093FB2C File Offset: 0x0093DD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DrillMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.DrillMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4DD RID: 120029 RVA: 0x0093FB74 File Offset: 0x0093DD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DrillMode(IntPtr l)
	{
		int result;
		try
		{
			string drillMode;
			LuaObject.checkType(l, 2, out drillMode);
			DrillUITask.DrillMode = drillMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4DE RID: 120030 RVA: 0x0093FBC0 File Offset: 0x0093DDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ManualMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.ManualMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4DF RID: 120031 RVA: 0x0093FC08 File Offset: 0x0093DE08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ManualMode(IntPtr l)
	{
		int result;
		try
		{
			string manualMode;
			LuaObject.checkType(l, 2, out manualMode);
			DrillUITask.ManualMode = manualMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E0 RID: 120032 RVA: 0x0093FC54 File Offset: 0x0093DE54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TrainingMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.TrainingMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E1 RID: 120033 RVA: 0x0093FC9C File Offset: 0x0093DE9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TrainingMode(IntPtr l)
	{
		int result;
		try
		{
			string trainingMode;
			LuaObject.checkType(l, 2, out trainingMode);
			DrillUITask.TrainingMode = trainingMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E2 RID: 120034 RVA: 0x0093FCE8 File Offset: 0x0093DEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TutorMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.TutorMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E3 RID: 120035 RVA: 0x0093FD30 File Offset: 0x0093DF30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TutorMode(IntPtr l)
	{
		int result;
		try
		{
			string tutorMode;
			LuaObject.checkType(l, 2, out tutorMode);
			DrillUITask.TutorMode = tutorMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E4 RID: 120036 RVA: 0x0093FD7C File Offset: 0x0093DF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.LuaExportHelper.m_curMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E5 RID: 120037 RVA: 0x0093FDC4 File Offset: 0x0093DFC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			string curMode;
			LuaObject.checkType(l, 2, out curMode);
			DrillUITask.LuaExportHelper.m_curMode = curMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E6 RID: 120038 RVA: 0x0093FE10 File Offset: 0x0093E010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_drillUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_drillUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E7 RID: 120039 RVA: 0x0093FE68 File Offset: 0x0093E068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drillUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			DrillUIController drillUIController;
			LuaObject.checkType<DrillUIController>(l, 2, out drillUIController);
			drillUITask.m_luaExportHelper.m_drillUIController = drillUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E8 RID: 120040 RVA: 0x0093FEC4 File Offset: 0x0093E0C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drillSoldierManualUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_drillSoldierManualUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4E9 RID: 120041 RVA: 0x0093FF1C File Offset: 0x0093E11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drillSoldierManualUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			DrillSoldierManualUIController drillSoldierManualUIController;
			LuaObject.checkType<DrillSoldierManualUIController>(l, 2, out drillSoldierManualUIController);
			drillUITask.m_luaExportHelper.m_drillSoldierManualUIController = drillSoldierManualUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4EA RID: 120042 RVA: 0x0093FF78 File Offset: 0x0093E178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drillTrainingUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_drillTrainingUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4EB RID: 120043 RVA: 0x0093FFD0 File Offset: 0x0093E1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drillTrainingUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			DrillTrainingUIController drillTrainingUIController;
			LuaObject.checkType<DrillTrainingUIController>(l, 2, out drillTrainingUIController);
			drillUITask.m_luaExportHelper.m_drillTrainingUIController = drillTrainingUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4EC RID: 120044 RVA: 0x0094002C File Offset: 0x0093E22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drillTutorUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_drillTutorUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4ED RID: 120045 RVA: 0x00940084 File Offset: 0x0093E284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drillTutorUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			DrillTutorUIController drillTutorUIController;
			LuaObject.checkType<DrillTutorUIController>(l, 2, out drillTutorUIController);
			drillUITask.m_luaExportHelper.m_drillTutorUIController = drillTutorUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4EE RID: 120046 RVA: 0x009400E0 File Offset: 0x0093E2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingModeFrom(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.LuaExportHelper.m_trainingModeFrom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4EF RID: 120047 RVA: 0x00940128 File Offset: 0x0093E328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingModeFrom(IntPtr l)
	{
		int result;
		try
		{
			string trainingModeFrom;
			LuaObject.checkType(l, 2, out trainingModeFrom);
			DrillUITask.LuaExportHelper.m_trainingModeFrom = trainingModeFrom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F0 RID: 120048 RVA: 0x00940174 File Offset: 0x0093E374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_courseId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.LuaExportHelper.m_courseId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F1 RID: 120049 RVA: 0x009401BC File Offset: 0x0093E3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_courseId(IntPtr l)
	{
		int result;
		try
		{
			int courseId;
			LuaObject.checkType(l, 2, out courseId);
			DrillUITask.LuaExportHelper.m_courseId = courseId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F2 RID: 120050 RVA: 0x00940208 File Offset: 0x0093E408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_curLayerDescIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F3 RID: 120051 RVA: 0x00940260 File Offset: 0x0093E460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int curLayerDescIndex;
			LuaObject.checkType(l, 2, out curLayerDescIndex);
			drillUITask.m_luaExportHelper.m_curLayerDescIndex = curLayerDescIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F4 RID: 120052 RVA: 0x009402BC File Offset: 0x0093E4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalSoldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_totalSoldierInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F5 RID: 120053 RVA: 0x00940314 File Offset: 0x0093E514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalSoldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			List<ConfigDataSoldierInfo> totalSoldierInfoList;
			LuaObject.checkType<List<ConfigDataSoldierInfo>>(l, 2, out totalSoldierInfoList);
			drillUITask.m_luaExportHelper.m_totalSoldierInfoList = totalSoldierInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F6 RID: 120054 RVA: 0x00940370 File Offset: 0x0093E570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSoldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_curSoldierInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F7 RID: 120055 RVA: 0x009403C8 File Offset: 0x0093E5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSoldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			List<ConfigDataSoldierInfo> curSoldierInfoList;
			LuaObject.checkType<List<ConfigDataSoldierInfo>>(l, 2, out curSoldierInfoList);
			drillUITask.m_luaExportHelper.m_curSoldierInfoList = curSoldierInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F8 RID: 120056 RVA: 0x00940424 File Offset: 0x0093E624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalSoldierManualPage(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_totalSoldierManualPage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4F9 RID: 120057 RVA: 0x0094047C File Offset: 0x0093E67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalSoldierManualPage(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int totalSoldierManualPage;
			LuaObject.checkType(l, 2, out totalSoldierManualPage);
			drillUITask.m_luaExportHelper.m_totalSoldierManualPage = totalSoldierManualPage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4FA RID: 120058 RVA: 0x009404D8 File Offset: 0x0093E6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSoldierManualPage(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_curSoldierManualPage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4FB RID: 120059 RVA: 0x00940530 File Offset: 0x0093E730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSoldierManualPage(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int curSoldierManualPage;
			LuaObject.checkType(l, 2, out curSoldierManualPage);
			drillUITask.m_luaExportHelper.m_curSoldierManualPage = curSoldierManualPage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4FC RID: 120060 RVA: 0x0094058C File Offset: 0x0093E78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierFilterRank(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_soldierFilterRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4FD RID: 120061 RVA: 0x009405E4 File Offset: 0x0093E7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierFilterRank(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int soldierFilterRank;
			LuaObject.checkType(l, 2, out soldierFilterRank);
			drillUITask.m_luaExportHelper.m_soldierFilterRank = soldierFilterRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4FE RID: 120062 RVA: 0x00940640 File Offset: 0x0093E840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyTag(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)drillUITask.m_luaExportHelper.m_armyTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D4FF RID: 120063 RVA: 0x00940698 File Offset: 0x0093E898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyTag(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			ArmyTag armyTag;
			LuaObject.checkEnum<ArmyTag>(l, 2, out armyTag);
			drillUITask.m_luaExportHelper.m_armyTag = armyTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D500 RID: 120064 RVA: 0x009406F4 File Offset: 0x0093E8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D501 RID: 120065 RVA: 0x0094074C File Offset: 0x0093E94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			drillUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D502 RID: 120066 RVA: 0x009407A8 File Offset: 0x0093E9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D503 RID: 120067 RVA: 0x00940800 File Offset: 0x0093EA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			drillUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D504 RID: 120068 RVA: 0x0094085C File Offset: 0x0093EA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D505 RID: 120069 RVA: 0x009408B4 File Offset: 0x0093EAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			drillUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D506 RID: 120070 RVA: 0x00940910 File Offset: 0x0093EB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D507 RID: 120071 RVA: 0x00940968 File Offset: 0x0093EB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			drillUITask.m_luaExportHelper.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D508 RID: 120072 RVA: 0x009409C4 File Offset: 0x0093EBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getSoldierTechId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DrillUITask.LuaExportHelper.m_getSoldierTechId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D509 RID: 120073 RVA: 0x00940A0C File Offset: 0x0093EC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getSoldierTechId(IntPtr l)
	{
		int result;
		try
		{
			int getSoldierTechId;
			LuaObject.checkType(l, 2, out getSoldierTechId);
			DrillUITask.LuaExportHelper.m_getSoldierTechId = getSoldierTechId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D50A RID: 120074 RVA: 0x00940A58 File Offset: 0x0093EC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedShowFadeIn(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.m_isNeedShowFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D50B RID: 120075 RVA: 0x00940AB0 File Offset: 0x0093ECB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedShowFadeIn(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			bool isNeedShowFadeIn;
			LuaObject.checkType(l, 2, out isNeedShowFadeIn);
			drillUITask.m_luaExportHelper.m_isNeedShowFadeIn = isNeedShowFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D50C RID: 120076 RVA: 0x00940B0C File Offset: 0x0093ED0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D50D RID: 120077 RVA: 0x00940B64 File Offset: 0x0093ED64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			DrillUITask drillUITask = (DrillUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D50E RID: 120078 RVA: 0x00940BBC File Offset: 0x0093EDBC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DrillUITask");
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.SetTotalSoldierInfoListWithFilter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.PushAndPopLayerByState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUIController_OnManualButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUIController_OnTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUIController_OnAssistanceTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUIController_OnAssistanceStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUIController_OnAssistanceGetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillSoldierManualUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillSoldierManualUIController_OnNeedUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillSoldierManualUIController_OnGoToTraingTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTrainingUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTrainingUIController_OnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTrainingUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTrainingUIController_OnTechLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTrainingUIController_OnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTrainingUIController_OnGotoGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTutorUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTutorUIController_OnShowTutorHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.DrillTutorUIController_OnConfirmAssistant);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.UpdateTimeText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache37);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache39, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3B, true);
		string name3 = "DrillMode";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_DrillMode);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_DrillMode);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3D, false);
		string name4 = "ManualMode";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_ManualMode);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_ManualMode);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache3F, false);
		string name5 = "TrainingMode";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_TrainingMode);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_TrainingMode);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache41, false);
		string name6 = "TutorMode";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_TutorMode);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_TutorMode);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache43, false);
		string name7 = "m_curMode";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_curMode);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_curMode);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache45, false);
		string name8 = "m_drillUIController";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_drillUIController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_drillUIController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache47, true);
		string name9 = "m_drillSoldierManualUIController";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_drillSoldierManualUIController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_drillSoldierManualUIController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache49, true);
		string name10 = "m_drillTrainingUIController";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_drillTrainingUIController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_drillTrainingUIController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4B, true);
		string name11 = "m_drillTutorUIController";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_drillTutorUIController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_drillTutorUIController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4D, true);
		string name12 = "m_trainingModeFrom";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_trainingModeFrom);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_trainingModeFrom);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache4F, false);
		string name13 = "m_courseId";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_courseId);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_courseId);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache51, false);
		string name14 = "m_curLayerDescIndex";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_curLayerDescIndex);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_curLayerDescIndex);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache53, true);
		string name15 = "m_totalSoldierInfoList";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_totalSoldierInfoList);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_totalSoldierInfoList);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache55, true);
		string name16 = "m_curSoldierInfoList";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_curSoldierInfoList);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_curSoldierInfoList);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache57, true);
		string name17 = "m_totalSoldierManualPage";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_totalSoldierManualPage);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_totalSoldierManualPage);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache59, true);
		string name18 = "m_curSoldierManualPage";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_curSoldierManualPage);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_curSoldierManualPage);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5B, true);
		string name19 = "m_soldierFilterRank";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_soldierFilterRank);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_soldierFilterRank);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5D, true);
		string name20 = "m_armyTag";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_armyTag);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_armyTag);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache5F, true);
		string name21 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_nowSeconds);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache61, true);
		string name22 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_configDataLoader);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache63, true);
		string name23 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_playerContext);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache65, true);
		string name24 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_slot);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_slot);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache67, true);
		string name25 = "m_getSoldierTechId";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_getSoldierTechId);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_getSoldierTechId);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache69, false);
		string name26 = "m_isNeedShowFadeIn";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_m_isNeedShowFadeIn);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.set_m_isNeedShowFadeIn);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6B, true);
		string name27 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6C, null, true);
		string name28 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6D, null, true);
		if (Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_DrillUITask.<>f__mg$cache6E, typeof(DrillUITask), typeof(UITask));
	}

	// Token: 0x04013647 RID: 79431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013648 RID: 79432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013649 RID: 79433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401364A RID: 79434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401364B RID: 79435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401364C RID: 79436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401364D RID: 79437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401364E RID: 79438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401364F RID: 79439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013650 RID: 79440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013651 RID: 79441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013652 RID: 79442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013653 RID: 79443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013654 RID: 79444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013655 RID: 79445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013656 RID: 79446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013657 RID: 79447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013658 RID: 79448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013659 RID: 79449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401365A RID: 79450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401365B RID: 79451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401365C RID: 79452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401365D RID: 79453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401365E RID: 79454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401365F RID: 79455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013660 RID: 79456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013661 RID: 79457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013662 RID: 79458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013663 RID: 79459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013664 RID: 79460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013665 RID: 79461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013666 RID: 79462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013667 RID: 79463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013668 RID: 79464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013669 RID: 79465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401366A RID: 79466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401366B RID: 79467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401366C RID: 79468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401366D RID: 79469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401366E RID: 79470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401366F RID: 79471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013670 RID: 79472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013671 RID: 79473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013672 RID: 79474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013673 RID: 79475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013674 RID: 79476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013675 RID: 79477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013676 RID: 79478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013677 RID: 79479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013678 RID: 79480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013679 RID: 79481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401367A RID: 79482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401367B RID: 79483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401367C RID: 79484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401367D RID: 79485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401367E RID: 79486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401367F RID: 79487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013680 RID: 79488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013681 RID: 79489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013682 RID: 79490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013683 RID: 79491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013684 RID: 79492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013685 RID: 79493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013686 RID: 79494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013687 RID: 79495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013688 RID: 79496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013689 RID: 79497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401368A RID: 79498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401368B RID: 79499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401368C RID: 79500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401368D RID: 79501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401368E RID: 79502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401368F RID: 79503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013690 RID: 79504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013691 RID: 79505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013692 RID: 79506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013693 RID: 79507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013694 RID: 79508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013695 RID: 79509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013696 RID: 79510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013697 RID: 79511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013698 RID: 79512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013699 RID: 79513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401369A RID: 79514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401369B RID: 79515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401369C RID: 79516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401369D RID: 79517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401369E RID: 79518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401369F RID: 79519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040136A0 RID: 79520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040136A1 RID: 79521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040136A2 RID: 79522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040136A3 RID: 79523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040136A4 RID: 79524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040136A5 RID: 79525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040136A6 RID: 79526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040136A7 RID: 79527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040136A8 RID: 79528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040136A9 RID: 79529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040136AA RID: 79530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040136AB RID: 79531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040136AC RID: 79532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040136AD RID: 79533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040136AE RID: 79534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040136AF RID: 79535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040136B0 RID: 79536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040136B1 RID: 79537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040136B2 RID: 79538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040136B3 RID: 79539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040136B4 RID: 79540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040136B5 RID: 79541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;
}
