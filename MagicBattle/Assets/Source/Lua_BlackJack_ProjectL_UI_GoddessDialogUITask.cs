using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200146C RID: 5228
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GoddessDialogUITask : LuaObject
{
	// Token: 0x0601E368 RID: 123752 RVA: 0x009B3C70 File Offset: 0x009B1E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GoddessDialogUITask o = new GoddessDialogUITask(name);
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

	// Token: 0x0601E369 RID: 123753 RVA: 0x009B3CC4 File Offset: 0x009B1EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = goddessDialogUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601E36A RID: 123754 RVA: 0x009B3D2C File Offset: 0x009B1F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E36B RID: 123755 RVA: 0x009B3D80 File Offset: 0x009B1F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			bool b = goddessDialogUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E36C RID: 123756 RVA: 0x009B3DDC File Offset: 0x009B1FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E36D RID: 123757 RVA: 0x009B3E30 File Offset: 0x009B2030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E36E RID: 123758 RVA: 0x009B3E84 File Offset: 0x009B2084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E36F RID: 123759 RVA: 0x009B3ED8 File Offset: 0x009B20D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitGoddessDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.InitGoddessDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E370 RID: 123760 RVA: 0x009B3F2C File Offset: 0x009B212C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitGoddessDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.UninitGoddessDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E371 RID: 123761 RVA: 0x009B3F80 File Offset: 0x009B2180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.InitDialogId();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E372 RID: 123762 RVA: 0x009B3FD4 File Offset: 0x009B21D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitJobChoiceValues(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.InitJobChoiceValues();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E373 RID: 123763 RVA: 0x009B4028 File Offset: 0x009B2228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendChoiceValues(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			List<ChoiceValue> choiceValues;
			LuaObject.checkType<List<ChoiceValue>>(l, 2, out choiceValues);
			goddessDialogUITask.m_luaExportHelper.AppendChoiceValues(choiceValues);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E374 RID: 123764 RVA: 0x009B4084 File Offset: 0x009B2284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowJobs(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			bool canSelect;
			LuaObject.checkType(l, 3, out canSelect);
			goddessDialogUITask.m_luaExportHelper.ShowJobs(idx, canSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E375 RID: 123765 RVA: 0x009B40F0 File Offset: 0x009B22F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartDialog(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			goddessDialogUITask.m_luaExportHelper.StartDialog(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E376 RID: 123766 RVA: 0x009B414C File Offset: 0x009B234C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowResultJobs(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.ShowResultJobs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E377 RID: 123767 RVA: 0x009B41A0 File Offset: 0x009B23A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnNext(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E378 RID: 123768 RVA: 0x009B41F4 File Offset: 0x009B23F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E379 RID: 123769 RVA: 0x009B4248 File Offset: 0x009B2448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnChoose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnChoose(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E37A RID: 123770 RVA: 0x009B42A4 File Offset: 0x009B24A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnShowJobInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnShowJobInfo(jobConnectionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E37B RID: 123771 RVA: 0x009B4300 File Offset: 0x009B2500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnConfirmJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnConfirmJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E37C RID: 123772 RVA: 0x009B4354 File Offset: 0x009B2554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnRetry(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnRetry();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E37D RID: 123773 RVA: 0x009B43A8 File Offset: 0x009B25A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnSelectJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnSelectJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E37E RID: 123774 RVA: 0x009B43FC File Offset: 0x009B25FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnPrevJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnPrevJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E37F RID: 123775 RVA: 0x009B4450 File Offset: 0x009B2650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUIController_OnNextJob(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.GoddessDialogUIController_OnNextJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E380 RID: 123776 RVA: 0x009B44A4 File Offset: 0x009B26A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = goddessDialogUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E381 RID: 123777 RVA: 0x009B450C File Offset: 0x009B270C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E382 RID: 123778 RVA: 0x009B4560 File Offset: 0x009B2760
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E383 RID: 123779 RVA: 0x009B45B4 File Offset: 0x009B27B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = goddessDialogUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E384 RID: 123780 RVA: 0x009B461C File Offset: 0x009B281C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = goddessDialogUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E385 RID: 123781 RVA: 0x009B4684 File Offset: 0x009B2884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			goddessDialogUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E386 RID: 123782 RVA: 0x009B46F0 File Offset: 0x009B28F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			bool b = goddessDialogUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E387 RID: 123783 RVA: 0x009B474C File Offset: 0x009B294C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			List<string> o = goddessDialogUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E388 RID: 123784 RVA: 0x009B47A8 File Offset: 0x009B29A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E389 RID: 123785 RVA: 0x009B47FC File Offset: 0x009B29FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E38A RID: 123786 RVA: 0x009B4850 File Offset: 0x009B2A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E38B RID: 123787 RVA: 0x009B48A4 File Offset: 0x009B2AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E38C RID: 123788 RVA: 0x009B48F8 File Offset: 0x009B2AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E38D RID: 123789 RVA: 0x009B494C File Offset: 0x009B2B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			goddessDialogUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E38E RID: 123790 RVA: 0x009B49A8 File Offset: 0x009B2BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			goddessDialogUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E38F RID: 123791 RVA: 0x009B4A04 File Offset: 0x009B2C04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			goddessDialogUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E390 RID: 123792 RVA: 0x009B4A60 File Offset: 0x009B2C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			goddessDialogUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E391 RID: 123793 RVA: 0x009B4ABC File Offset: 0x009B2CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			bool b = goddessDialogUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E392 RID: 123794 RVA: 0x009B4B18 File Offset: 0x009B2D18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			bool b = goddessDialogUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E393 RID: 123795 RVA: 0x009B4B74 File Offset: 0x009B2D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			bool b = goddessDialogUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E394 RID: 123796 RVA: 0x009B4BD0 File Offset: 0x009B2DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			UITaskBase o = goddessDialogUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E395 RID: 123797 RVA: 0x009B4C2C File Offset: 0x009B2E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E396 RID: 123798 RVA: 0x009B4C80 File Offset: 0x009B2E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			goddessDialogUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E397 RID: 123799 RVA: 0x009B4CD4 File Offset: 0x009B2ED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			goddessDialogUITask.m_luaExportHelper.__callDele_EventOnClose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E398 RID: 123800 RVA: 0x009B4D30 File Offset: 0x009B2F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			goddessDialogUITask.m_luaExportHelper.__clearDele_EventOnClose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E399 RID: 123801 RVA: 0x009B4D8C File Offset: 0x009B2F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					goddessDialogUITask.EventOnClose -= value;
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

	// Token: 0x0601E39A RID: 123802 RVA: 0x009B4E0C File Offset: 0x009B300C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E39B RID: 123803 RVA: 0x009B4E64 File Offset: 0x009B3064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			goddessDialogUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E39C RID: 123804 RVA: 0x009B4EC0 File Offset: 0x009B30C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E39D RID: 123805 RVA: 0x009B4F18 File Offset: 0x009B3118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			goddessDialogUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E39E RID: 123806 RVA: 0x009B4F74 File Offset: 0x009B3174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goddessDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_goddessDialogUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E39F RID: 123807 RVA: 0x009B4FCC File Offset: 0x009B31CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goddessDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			GoddessDialogUIController goddessDialogUIController;
			LuaObject.checkType<GoddessDialogUIController>(l, 2, out goddessDialogUIController);
			goddessDialogUITask.m_luaExportHelper.m_goddessDialogUIController = goddessDialogUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A0 RID: 123808 RVA: 0x009B5028 File Offset: 0x009B3228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_dialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A1 RID: 123809 RVA: 0x009B5080 File Offset: 0x009B3280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			ConfigDataGoddessDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataGoddessDialogInfo>(l, 2, out dialogInfo);
			goddessDialogUITask.m_luaExportHelper.m_dialogInfo = dialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A2 RID: 123810 RVA: 0x009B50DC File Offset: 0x009B32DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_heroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A3 RID: 123811 RVA: 0x009B5134 File Offset: 0x009B3334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			goddessDialogUITask.m_luaExportHelper.m_heroInfo = heroInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A4 RID: 123812 RVA: 0x009B5190 File Offset: 0x009B3390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curJobIndex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_curJobIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A5 RID: 123813 RVA: 0x009B51E8 File Offset: 0x009B33E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curJobIndex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int curJobIndex;
			LuaObject.checkType(l, 2, out curJobIndex);
			goddessDialogUITask.m_luaExportHelper.m_curJobIndex = curJobIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A6 RID: 123814 RVA: 0x009B5244 File Offset: 0x009B3444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobChoiceValues(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_jobChoiceValues);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A7 RID: 123815 RVA: 0x009B529C File Offset: 0x009B349C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobChoiceValues(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			List<GoddessDialogUITask.JobChoiceValue> jobChoiceValues;
			LuaObject.checkType<List<GoddessDialogUITask.JobChoiceValue>>(l, 2, out jobChoiceValues);
			goddessDialogUITask.m_luaExportHelper.m_jobChoiceValues = jobChoiceValues;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A8 RID: 123816 RVA: 0x009B52F8 File Offset: 0x009B34F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_startDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_startDialogId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3A9 RID: 123817 RVA: 0x009B5350 File Offset: 0x009B3550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int startDialogId;
			LuaObject.checkType(l, 2, out startDialogId);
			goddessDialogUITask.m_luaExportHelper.m_startDialogId = startDialogId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3AA RID: 123818 RVA: 0x009B53AC File Offset: 0x009B35AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questionStartDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_questionStartDialogId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3AB RID: 123819 RVA: 0x009B5404 File Offset: 0x009B3604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questionStartDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int questionStartDialogId;
			LuaObject.checkType(l, 2, out questionStartDialogId);
			goddessDialogUITask.m_luaExportHelper.m_questionStartDialogId = questionStartDialogId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3AC RID: 123820 RVA: 0x009B5460 File Offset: 0x009B3660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_selectDialogId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3AD RID: 123821 RVA: 0x009B54B8 File Offset: 0x009B36B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int selectDialogId;
			LuaObject.checkType(l, 2, out selectDialogId);
			goddessDialogUITask.m_luaExportHelper.m_selectDialogId = selectDialogId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3AE RID: 123822 RVA: 0x009B5514 File Offset: 0x009B3714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_finalDialogId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3AF RID: 123823 RVA: 0x009B556C File Offset: 0x009B376C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalDialogId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int finalDialogId;
			LuaObject.checkType(l, 2, out finalDialogId);
			goddessDialogUITask.m_luaExportHelper.m_finalDialogId = finalDialogId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3B0 RID: 123824 RVA: 0x009B55C8 File Offset: 0x009B37C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_protagonistId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_protagonistId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3B1 RID: 123825 RVA: 0x009B5620 File Offset: 0x009B3820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_protagonistId(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			int protagonistId;
			LuaObject.checkType(l, 2, out protagonistId);
			goddessDialogUITask.m_luaExportHelper.m_protagonistId = protagonistId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3B2 RID: 123826 RVA: 0x009B567C File Offset: 0x009B387C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goddessCharImageInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.m_goddessCharImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3B3 RID: 123827 RVA: 0x009B56D4 File Offset: 0x009B38D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goddessCharImageInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo goddessCharImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out goddessCharImageInfo);
			goddessDialogUITask.m_luaExportHelper.m_goddessCharImageInfo = goddessCharImageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3B4 RID: 123828 RVA: 0x009B5730 File Offset: 0x009B3930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3B5 RID: 123829 RVA: 0x009B5788 File Offset: 0x009B3988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask goddessDialogUITask = (GoddessDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3B6 RID: 123830 RVA: 0x009B57E0 File Offset: 0x009B39E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GoddessDialogUITask");
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.InitGoddessDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.UninitGoddessDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.InitDialogId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.InitJobChoiceValues);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.AppendChoiceValues);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.ShowJobs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.StartDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.ShowResultJobs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnChoose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnShowJobInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnConfirmJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnRetry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnSelectJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnPrevJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.GoddessDialogUIController_OnNextJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache2F);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache30, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache32, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache34, true);
		string name4 = "m_goddessDialogUIController";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_goddessDialogUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_goddessDialogUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache36, true);
		string name5 = "m_dialogInfo";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_dialogInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_dialogInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache38, true);
		string name6 = "m_heroInfo";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_heroInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_heroInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3A, true);
		string name7 = "m_curJobIndex";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_curJobIndex);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_curJobIndex);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3C, true);
		string name8 = "m_jobChoiceValues";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_jobChoiceValues);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_jobChoiceValues);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3E, true);
		string name9 = "m_startDialogId";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_startDialogId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_startDialogId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache40, true);
		string name10 = "m_questionStartDialogId";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_questionStartDialogId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_questionStartDialogId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache42, true);
		string name11 = "m_selectDialogId";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_selectDialogId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_selectDialogId);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache44, true);
		string name12 = "m_finalDialogId";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_finalDialogId);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_finalDialogId);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache46, true);
		string name13 = "m_protagonistId";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_protagonistId);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_protagonistId);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache48, true);
		string name14 = "m_goddessCharImageInfo";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_m_goddessCharImageInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.set_m_goddessCharImageInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4A, true);
		string name15 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4B, null, true);
		string name16 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4C, null, true);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.<>f__mg$cache4D, typeof(GoddessDialogUITask), typeof(UITask));
	}

	// Token: 0x04014472 RID: 83058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014473 RID: 83059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014474 RID: 83060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014475 RID: 83061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014476 RID: 83062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014477 RID: 83063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014478 RID: 83064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014479 RID: 83065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401447A RID: 83066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401447B RID: 83067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401447C RID: 83068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401447D RID: 83069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401447E RID: 83070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401447F RID: 83071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014480 RID: 83072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014481 RID: 83073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014482 RID: 83074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014483 RID: 83075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014484 RID: 83076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014485 RID: 83077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014486 RID: 83078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014487 RID: 83079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014488 RID: 83080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014489 RID: 83081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401448A RID: 83082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401448B RID: 83083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401448C RID: 83084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401448D RID: 83085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401448E RID: 83086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401448F RID: 83087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014490 RID: 83088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014491 RID: 83089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014492 RID: 83090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014493 RID: 83091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014494 RID: 83092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014495 RID: 83093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014496 RID: 83094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014497 RID: 83095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014498 RID: 83096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014499 RID: 83097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401449A RID: 83098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401449B RID: 83099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401449C RID: 83100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401449D RID: 83101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401449E RID: 83102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401449F RID: 83103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040144A0 RID: 83104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040144A1 RID: 83105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040144A2 RID: 83106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040144A3 RID: 83107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040144A4 RID: 83108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040144A5 RID: 83109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040144A6 RID: 83110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040144A7 RID: 83111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040144A8 RID: 83112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040144A9 RID: 83113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040144AA RID: 83114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040144AB RID: 83115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040144AC RID: 83116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040144AD RID: 83117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040144AE RID: 83118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040144AF RID: 83119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040144B0 RID: 83120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040144B1 RID: 83121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040144B2 RID: 83122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040144B3 RID: 83123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040144B4 RID: 83124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040144B5 RID: 83125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040144B6 RID: 83126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040144B7 RID: 83127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040144B8 RID: 83128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040144B9 RID: 83129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040144BA RID: 83130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040144BB RID: 83131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040144BC RID: 83132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040144BD RID: 83133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040144BE RID: 83134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040144BF RID: 83135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;
}
