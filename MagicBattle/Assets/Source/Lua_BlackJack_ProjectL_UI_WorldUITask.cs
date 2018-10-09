using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015EA RID: 5610
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldUITask : LuaObject
{
	// Token: 0x06022629 RID: 140841 RVA: 0x00BC6CB4 File Offset: 0x00BC4EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			WorldUITask o = new WorldUITask(name);
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

	// Token: 0x0602262A RID: 140842 RVA: 0x00BC6D08 File Offset: 0x00BC4F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowSign(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.WorldUIController_OnShowSign();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602262B RID: 140843 RVA: 0x00BC6D54 File Offset: 0x00BC4F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowActivityNotice(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.WorldUIController_OnShowActivityNotice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602262C RID: 140844 RVA: 0x00BC6DA0 File Offset: 0x00BC4FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClientWorld(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ClientWorld clientWorld = worldUITask.GetClientWorld();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602262D RID: 140845 RVA: 0x00BC6DF4 File Offset: 0x00BC4FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWaypointClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			worldUITask.OnWaypointClick(waypointInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602262E RID: 140846 RVA: 0x00BC6E4C File Offset: 0x00BC504C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScreenEffect(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			worldUITask.OnScreenEffect(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602262F RID: 140847 RVA: 0x00BC6EA4 File Offset: 0x00BC50A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_ShowHide_s(IntPtr l)
	{
		int result;
		try
		{
			bool isShow;
			LuaObject.checkType(l, 1, out isShow);
			bool saveShowState;
			LuaObject.checkType(l, 2, out saveShowState);
			WorldUITask.WorldUIController_ShowHide(isShow, saveShowState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022630 RID: 140848 RVA: 0x00BC6EFC File Offset: 0x00BC50FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWorld_s(IntPtr l)
	{
		int result;
		try
		{
			bool show;
			LuaObject.checkType(l, 1, out show);
			WorldUITask.ShowWorld(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022631 RID: 140849 RVA: 0x00BC6F48 File Offset: 0x00BC5148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleHappening_s(IntPtr l)
	{
		int result;
		try
		{
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 1, out battleType);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			WorldUITask.StartBattleHappening(battleType, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022632 RID: 140850 RVA: 0x00BC6FA0 File Offset: 0x00BC51A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleAttackFailResult_s(IntPtr l)
	{
		int result2;
		try
		{
			int result;
			LuaObject.checkType(l, 1, out result);
			UIIntent currIntent;
			LuaObject.checkType<UIIntent>(l, 2, out currIntent);
			WorldUITask.HandleAttackFailResult(result, currIntent);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06022633 RID: 140851 RVA: 0x00BC6FF8 File Offset: 0x00BC51F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUnchartedSubUITask_s(IntPtr l)
	{
		int result;
		try
		{
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 1, out battleType);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			WorldUITask.StartUnchartedSubUITask(battleType, chapterId, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022634 RID: 140852 RVA: 0x00BC705C File Offset: 0x00BC525C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGetPathTargetUITask_s(IntPtr l)
	{
		int result;
		try
		{
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 1, out getPath);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 2, out fromIntent);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			WorldUITask.StartGetPathTargetUITask(getPath, fromIntent, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022635 RID: 140853 RVA: 0x00BC70C0 File Offset: 0x00BC52C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06022636 RID: 140854 RVA: 0x00BC711C File Offset: 0x00BC531C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectPlayerAssets(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.CollectPlayerAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022637 RID: 140855 RVA: 0x00BC7170 File Offset: 0x00BC5370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectEventAssets(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.CollectEventAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022638 RID: 140856 RVA: 0x00BC71C4 File Offset: 0x00BC53C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectMonthCardAssets(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.CollectMonthCardAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022639 RID: 140857 RVA: 0x00BC7218 File Offset: 0x00BC5418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602263A RID: 140858 RVA: 0x00BC726C File Offset: 0x00BC546C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602263B RID: 140859 RVA: 0x00BC72C0 File Offset: 0x00BC54C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602263C RID: 140860 RVA: 0x00BC7314 File Offset: 0x00BC5514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602263D RID: 140861 RVA: 0x00BC7368 File Offset: 0x00BC5568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602263E RID: 140862 RVA: 0x00BC73BC File Offset: 0x00BC55BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0602263F RID: 140863 RVA: 0x00BC7424 File Offset: 0x00BC5624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06022640 RID: 140864 RVA: 0x00BC748C File Offset: 0x00BC568C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022641 RID: 140865 RVA: 0x00BC74E0 File Offset: 0x00BC56E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAllView(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.HideAllView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022642 RID: 140866 RVA: 0x00BC7534 File Offset: 0x00BC5734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022643 RID: 140867 RVA: 0x00BC7588 File Offset: 0x00BC5788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitWorldMapUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.InitWorldMapUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022644 RID: 140868 RVA: 0x00BC75DC File Offset: 0x00BC57DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitWorldMapUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UninitWorldMapUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022645 RID: 140869 RVA: 0x00BC7630 File Offset: 0x00BC5830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitWorldUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.InitWorldUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022646 RID: 140870 RVA: 0x00BC7684 File Offset: 0x00BC5884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitWorldUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UninitWorldUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022647 RID: 140871 RVA: 0x00BC76D8 File Offset: 0x00BC58D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022648 RID: 140872 RVA: 0x00BC772C File Offset: 0x00BC592C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRedMarks(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateRedMarks();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022649 RID: 140873 RVA: 0x00BC7780 File Offset: 0x00BC5980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdatePlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdatePlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602264A RID: 140874 RVA: 0x00BC77D4 File Offset: 0x00BC59D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateCurrentScenario();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602264B RID: 140875 RVA: 0x00BC7828 File Offset: 0x00BC5A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateHeroRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602264C RID: 140876 RVA: 0x00BC787C File Offset: 0x00BC5A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMissionRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateMissionRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602264D RID: 140877 RVA: 0x00BC78D0 File Offset: 0x00BC5AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateActivityRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateActivityRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602264E RID: 140878 RVA: 0x00BC7924 File Offset: 0x00BC5B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateFriendRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateFriendRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602264F RID: 140879 RVA: 0x00BC7978 File Offset: 0x00BC5B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDrillRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateDrillRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022650 RID: 140880 RVA: 0x00BC79CC File Offset: 0x00BC5BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateFetterRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateFetterRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022651 RID: 140881 RVA: 0x00BC7A20 File Offset: 0x00BC5C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGuildRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateGuildRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022652 RID: 140882 RVA: 0x00BC7A74 File Offset: 0x00BC5C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateWorldEventRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateWorldEventRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022653 RID: 140883 RVA: 0x00BC7AC8 File Offset: 0x00BC5CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateInvestigationButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateInvestigationButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022654 RID: 140884 RVA: 0x00BC7B1C File Offset: 0x00BC5D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateOpenServiceActivityButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateOpenServiceActivityButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022655 RID: 140885 RVA: 0x00BC7B70 File Offset: 0x00BC5D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateCooperateBattleButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateCooperateBattleButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022656 RID: 140886 RVA: 0x00BC7BC4 File Offset: 0x00BC5DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMonthCardInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateMonthCardInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022657 RID: 140887 RVA: 0x00BC7C18 File Offset: 0x00BC5E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSlowTick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.OnSlowTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022658 RID: 140888 RVA: 0x00BC7C6C File Offset: 0x00BC5E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEventList(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ShowEventList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022659 RID: 140889 RVA: 0x00BC7CC0 File Offset: 0x00BC5EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.HasRandomEvent();
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

	// Token: 0x0602265A RID: 140890 RVA: 0x00BC7D1C File Offset: 0x00BC5F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateNewChatCount(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateNewChatCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602265B RID: 140891 RVA: 0x00BC7D70 File Offset: 0x00BC5F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateNewMailCount(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UpdateNewMailCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602265C RID: 140892 RVA: 0x00BC7DC4 File Offset: 0x00BC5FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateClientWorld(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.CreateClientWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602265D RID: 140893 RVA: 0x00BC7E18 File Offset: 0x00BC6018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyClientWorld(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.DestroyClientWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602265E RID: 140894 RVA: 0x00BC7E6C File Offset: 0x00BC606C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartClientWorld(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartClientWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602265F RID: 140895 RVA: 0x00BC7EC0 File Offset: 0x00BC60C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextWorldStep(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool checkWorldUIGetReady;
			LuaObject.checkType(l, 2, out checkWorldUIGetReady);
			worldUITask.m_luaExportHelper.NextWorldStep(checkWorldUIGetReady);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022660 RID: 140896 RVA: 0x00BC7F1C File Offset: 0x00BC611C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIGetReady(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIGetReady();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022661 RID: 140897 RVA: 0x00BC7F70 File Offset: 0x00BC6170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClickFirstWaypoint(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ClickFirstWaypoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022662 RID: 140898 RVA: 0x00BC7FC4 File Offset: 0x00BC61C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartSetProtagonistNetTask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int protagonistId;
			LuaObject.checkType(l, 2, out protagonistId);
			worldUITask.m_luaExportHelper.StartSetProtagonistNetTask(protagonistId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022663 RID: 140899 RVA: 0x00BC8020 File Offset: 0x00BC6220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowMainButtonBar(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowMainButtonBar(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022664 RID: 140900 RVA: 0x00BC807C File Offset: 0x00BC627C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowPlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022665 RID: 140901 RVA: 0x00BC80D0 File Offset: 0x00BC62D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnCompass(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnCompass();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022666 RID: 140902 RVA: 0x00BC8124 File Offset: 0x00BC6324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnCurrentScenario();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022667 RID: 140903 RVA: 0x00BC8178 File Offset: 0x00BC6378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnUnlockScenarioGotoRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			worldUITask.m_luaExportHelper.WorldUIController_OnUnlockScenarioGotoRiftLevel(riftLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022668 RID: 140904 RVA: 0x00BC81D4 File Offset: 0x00BC63D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnGotoEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventInfo);
			worldUITask.m_luaExportHelper.WorldUIController_OnGotoEvent(waypointInfo, eventInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022669 RID: 140905 RVA: 0x00BC8240 File Offset: 0x00BC6440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnStartPastScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			worldUITask.m_luaExportHelper.WorldUIController_OnStartPastScenario(scenarioInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602266A RID: 140906 RVA: 0x00BC829C File Offset: 0x00BC649C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnClosePastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnClosePastScenarioList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602266B RID: 140907 RVA: 0x00BC82F0 File Offset: 0x00BC64F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602266C RID: 140908 RVA: 0x00BC8344 File Offset: 0x00BC6544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowHero(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602266D RID: 140909 RVA: 0x00BC8398 File Offset: 0x00BC6598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowBag(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602266E RID: 140910 RVA: 0x00BC83EC File Offset: 0x00BC65EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowMission(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowMission();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602266F RID: 140911 RVA: 0x00BC8440 File Offset: 0x00BC6640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowFetter(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowFetter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022670 RID: 140912 RVA: 0x00BC8494 File Offset: 0x00BC6694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowStore(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022671 RID: 140913 RVA: 0x00BC84E8 File Offset: 0x00BC66E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowSelectCard(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowSelectCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022672 RID: 140914 RVA: 0x00BC853C File Offset: 0x00BC673C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowDrill(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowDrill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022673 RID: 140915 RVA: 0x00BC8590 File Offset: 0x00BC6790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowFriend(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowFriend();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022674 RID: 140916 RVA: 0x00BC85E4 File Offset: 0x00BC67E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowGuild(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowGuild();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022675 RID: 140917 RVA: 0x00BC8638 File Offset: 0x00BC6838
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowUncharted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022676 RID: 140918 RVA: 0x00BC868C File Offset: 0x00BC688C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowArena(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022677 RID: 140919 RVA: 0x00BC86E0 File Offset: 0x00BC68E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowRift(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowRift();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022678 RID: 140920 RVA: 0x00BC8734 File Offset: 0x00BC6934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowTest(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowTest();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022679 RID: 140921 RVA: 0x00BC8788 File Offset: 0x00BC6988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowCooperateBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602267A RID: 140922 RVA: 0x00BC87DC File Offset: 0x00BC69DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowMail(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowMail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602267B RID: 140923 RVA: 0x00BC8830 File Offset: 0x00BC6A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowChat(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602267C RID: 140924 RVA: 0x00BC8884 File Offset: 0x00BC6A84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowRanking(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowRanking();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602267D RID: 140925 RVA: 0x00BC88D8 File Offset: 0x00BC6AD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnShowActivity(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowActivity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602267E RID: 140926 RVA: 0x00BC892C File Offset: 0x00BC6B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnShowOpenServiceActivity(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnShowOpenServiceActivity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602267F RID: 140927 RVA: 0x00BC8980 File Offset: 0x00BC6B80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnMonthCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnMonthCardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022680 RID: 140928 RVA: 0x00BC89D4 File Offset: 0x00BC6BD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnRefreshMonthCardPanel(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool curIsOpenState;
			LuaObject.checkType(l, 2, out curIsOpenState);
			worldUITask.m_luaExportHelper.WorldUIController_OnRefreshMonthCardPanel(curIsOpenState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022681 RID: 140929 RVA: 0x00BC8A30 File Offset: 0x00BC6C30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldUIController_OnMonthCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			worldUITask.m_luaExportHelper.WorldUIController_OnMonthCardItemClick(cardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022682 RID: 140930 RVA: 0x00BC8A8C File Offset: 0x00BC6C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnMonthCardItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			worldUITask.m_luaExportHelper.WorldUIController_OnMonthCardItemBuyClick(cardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022683 RID: 140931 RVA: 0x00BC8AE8 File Offset: 0x00BC6CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnOpenWebInvestigation(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnOpenWebInvestigation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022684 RID: 140932 RVA: 0x00BC8B3C File Offset: 0x00BC6D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnYYBButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnYYBButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022685 RID: 140933 RVA: 0x00BC8B90 File Offset: 0x00BC6D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUIController_OnOppoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldUIController_OnOppoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022686 RID: 140934 RVA: 0x00BC8BE4 File Offset: 0x00BC6DE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PDSDK_OnDoQuestionSucceed(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PDSDK_OnDoQuestionSucceed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022687 RID: 140935 RVA: 0x00BC8C38 File Offset: 0x00BC6E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnDoQuestionFailed(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PDSDK_OnDoQuestionFailed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022688 RID: 140936 RVA: 0x00BC8C8C File Offset: 0x00BC6E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardGoodsUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.GetRewardGoodsUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022689 RID: 140937 RVA: 0x00BC8CE8 File Offset: 0x00BC6EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardGoodsUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.GetRewardGoodsUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602268A RID: 140938 RVA: 0x00BC8D3C File Offset: 0x00BC6F3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChestUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.ChestUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602268B RID: 140939 RVA: 0x00BC8D98 File Offset: 0x00BC6F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChestUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ChestUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602268C RID: 140940 RVA: 0x00BC8DEC File Offset: 0x00BC6FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldMapUIController_OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldMapUIController_OnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602268D RID: 140941 RVA: 0x00BC8E40 File Offset: 0x00BC7040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldMapUIController_OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldMapUIController_OnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602268E RID: 140942 RVA: 0x00BC8E94 File Offset: 0x00BC7094
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldMapUIController_OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldMapUIController_OnPointerClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602268F RID: 140943 RVA: 0x00BC8EE8 File Offset: 0x00BC70E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerResourceUIController_OnAddGold(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerResourceUIController_OnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022690 RID: 140944 RVA: 0x00BC8F3C File Offset: 0x00BC713C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerResourceUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerResourceUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022691 RID: 140945 RVA: 0x00BC8F90 File Offset: 0x00BC7190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnMailsChangedNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnMailsChangedNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022692 RID: 140946 RVA: 0x00BC8FE4 File Offset: 0x00BC71E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnFriendInviteNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnFriendInviteNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022693 RID: 140947 RVA: 0x00BC9038 File Offset: 0x00BC7238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnFriendInviteAcceptNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 2, out userSummy);
			worldUITask.m_luaExportHelper.PlayerContext_OnFriendInviteAcceptNtf(userSummy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022694 RID: 140948 RVA: 0x00BC9094 File Offset: 0x00BC7294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnFriendshipPointsReceivedNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnFriendshipPointsReceivedNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022695 RID: 140949 RVA: 0x00BC90E8 File Offset: 0x00BC72E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_EventOnGiftStoreBuyGoodsNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			worldUITask.m_luaExportHelper.PlayerContext_EventOnGiftStoreBuyGoodsNtf(orderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022696 RID: 140950 RVA: 0x00BC9144 File Offset: 0x00BC7344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnChatMessageNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ChatMessage msg;
			LuaObject.checkType<ChatMessage>(l, 2, out msg);
			worldUITask.m_luaExportHelper.PlayerContext_OnChatMessageNtf(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022697 RID: 140951 RVA: 0x00BC91A0 File Offset: 0x00BC73A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnMailReadAck(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldUITask.m_luaExportHelper.PlayerContext_OnMailReadAck(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022698 RID: 140952 RVA: 0x00BC91FC File Offset: 0x00BC73FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnPlayerInfoChangeNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnPlayerInfoChangeNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022699 RID: 140953 RVA: 0x00BC9250 File Offset: 0x00BC7450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnTeamRoomInviteNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			TeamRoomInviteInfo inviteInfo;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 2, out inviteInfo);
			worldUITask.m_luaExportHelper.PlayerContext_OnTeamRoomInviteNtf(inviteInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602269A RID: 140954 RVA: 0x00BC92AC File Offset: 0x00BC74AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattlePracticeInvitedNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			PVPInviteInfo inviteInfo;
			LuaObject.checkType<PVPInviteInfo>(l, 2, out inviteInfo);
			worldUITask.m_luaExportHelper.PlayerContext_OnBattlePracticeInvitedNtf(inviteInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602269B RID: 140955 RVA: 0x00BC9308 File Offset: 0x00BC7508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomTeamBattleJoinNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnBattleRoomTeamBattleJoinNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602269C RID: 140956 RVA: 0x00BC935C File Offset: 0x00BC755C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomPVPBattleJoinNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnBattleRoomPVPBattleJoinNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602269D RID: 140957 RVA: 0x00BC93B0 File Offset: 0x00BC75B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602269E RID: 140958 RVA: 0x00BC9404 File Offset: 0x00BC7604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602269F RID: 140959 RVA: 0x00BC9458 File Offset: 0x00BC7658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerContext_OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A0 RID: 140960 RVA: 0x00BC94AC File Offset: 0x00BC76AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			ConfigDataWaypointInfo prevWaypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 3, out prevWaypointInfo);
			worldUITask.m_luaExportHelper.StartScenario(scenarioInfo, prevWaypointInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A1 RID: 140961 RVA: 0x00BC9518 File Offset: 0x00BC7718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartWaypointEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			ConfigDataWaypointInfo prevWaypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 3, out prevWaypointInfo);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 4, out eventInfo);
			worldUITask.m_luaExportHelper.StartWaypointEvent(waypointInfo, prevWaypointInfo, eventInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A2 RID: 140962 RVA: 0x00BC9590 File Offset: 0x00BC7790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomBattle(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartBattleRoomBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A3 RID: 140963 RVA: 0x00BC95E4 File Offset: 0x00BC77E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _StartBattleHappening(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = worldUITask.m_luaExportHelper._StartBattleHappening(battleType, levelId);
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

	// Token: 0x060226A4 RID: 140964 RVA: 0x00BC9658 File Offset: 0x00BC7858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHappening(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 3, out battleInfo);
			int monsterLevel;
			LuaObject.checkType(l, 4, out monsterLevel);
			ConfigDataDialogInfo dialogBefore;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 5, out dialogBefore);
			ConfigDataDialogInfo dialogAfter;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 6, out dialogAfter);
			worldUITask.m_luaExportHelper.StartHappening(battleType, battleInfo, monsterLevel, dialogBefore, dialogAfter);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A5 RID: 140965 RVA: 0x00BC96E8 File Offset: 0x00BC78E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextHappeningStep(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.NextHappeningStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A6 RID: 140966 RVA: 0x00BC973C File Offset: 0x00BC793C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLevelWayPointMoveNetTask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 3, out onEnd);
			worldUITask.m_luaExportHelper.StartLevelWayPointMoveNetTask(waypointId, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A7 RID: 140967 RVA: 0x00BC97A8 File Offset: 0x00BC79A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLevelScenarioHandleNetTask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 3, out onEnd);
			worldUITask.m_luaExportHelper.StartLevelScenarioHandleNetTask(scenarioId, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226A8 RID: 140968 RVA: 0x00BC9814 File Offset: 0x00BC7A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelWayPointMoveNetTaskResult(IntPtr l)
	{
		int result2;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 3, out reward);
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 4, out onEnd);
			worldUITask.m_luaExportHelper.OnLevelWayPointMoveNetTaskResult(result, reward, onEnd);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x060226A9 RID: 140969 RVA: 0x00BC988C File Offset: 0x00BC7A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaypointReward(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			bool isChest;
			LuaObject.checkType(l, 3, out isChest);
			worldUITask.m_luaExportHelper.ShowWaypointReward(reward, isChest);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226AA RID: 140970 RVA: 0x00BC98F8 File Offset: 0x00BC7AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckChangeCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool checkWorldUIGetReady;
			LuaObject.checkType(l, 2, out checkWorldUIGetReady);
			bool b = worldUITask.m_luaExportHelper.CheckChangeCurrentScenario(checkWorldUIGetReady);
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

	// Token: 0x060226AB RID: 140971 RVA: 0x00BC9960 File Offset: 0x00BC7B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ChangeCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenario;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenario);
			bool checkWorldUIGetReady;
			LuaObject.checkType(l, 3, out checkWorldUIGetReady);
			IEnumerator o = worldUITask.m_luaExportHelper.Co_ChangeCurrentScenario(scenario, checkWorldUIGetReady);
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

	// Token: 0x060226AC RID: 140972 RVA: 0x00BC99D4 File Offset: 0x00BC7BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckOpenRiftChapter(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.CheckOpenRiftChapter();
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

	// Token: 0x060226AD RID: 140973 RVA: 0x00BC9A30 File Offset: 0x00BC7C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckOrderReward(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.CheckOrderReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226AE RID: 140974 RVA: 0x00BC9A84 File Offset: 0x00BC7C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckReturnToBeforeBattleUI(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.CheckReturnToBeforeBattleUI();
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

	// Token: 0x060226AF RID: 140975 RVA: 0x00BC9AE0 File Offset: 0x00BC7CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckOpenTeamRoomInfoUI(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.CheckOpenTeamRoomInfoUI();
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

	// Token: 0x060226B0 RID: 140976 RVA: 0x00BC9B3C File Offset: 0x00BC7D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTeamRoomInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartTeamRoomInfoUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226B1 RID: 140977 RVA: 0x00BC9B90 File Offset: 0x00BC7D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckInBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.CheckInBattleRoom();
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

	// Token: 0x060226B2 RID: 140978 RVA: 0x00BC9BEC File Offset: 0x00BC7DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveToPrevWaypoint(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool moveCamera;
			LuaObject.checkType(l, 2, out moveCamera);
			worldUITask.m_luaExportHelper.MoveToPrevWaypoint(moveCamera);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226B3 RID: 140979 RVA: 0x00BC9C48 File Offset: 0x00BC7E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerArriveWaypoint(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			ConfigDataWaypointInfo prevWaypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 3, out prevWaypointInfo);
			worldUITask.m_luaExportHelper.PlayerArriveWaypoint(waypointInfo, prevWaypointInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226B4 RID: 140980 RVA: 0x00BC9CB4 File Offset: 0x00BC7EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			bool b = worldUITask.m_luaExportHelper.ShowPastScenarioList(waypointInfo);
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

	// Token: 0x060226B5 RID: 140981 RVA: 0x00BC9D1C File Offset: 0x00BC7F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartShowFadeOutLoadingFadeIn(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Action fadeOutEnd;
			LuaObject.checkDelegate<Action>(l, 2, out fadeOutEnd);
			FadeStyle style;
			LuaObject.checkEnum<FadeStyle>(l, 3, out style);
			worldUITask.m_luaExportHelper.StartShowFadeOutLoadingFadeIn(fadeOutEnd, style);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226B6 RID: 140982 RVA: 0x00BC9D88 File Offset: 0x00BC7F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideFadeOutLoadingFadeIn(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.HideFadeOutLoadingFadeIn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226B7 RID: 140983 RVA: 0x00BC9DDC File Offset: 0x00BC7FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartPlayerInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartPlayerInfoUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226B8 RID: 140984 RVA: 0x00BC9E30 File Offset: 0x00BC8030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerInfoUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226B9 RID: 140985 RVA: 0x00BC9E84 File Offset: 0x00BC8084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.PlayerInfoUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226BA RID: 140986 RVA: 0x00BC9EE0 File Offset: 0x00BC80E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.PlayerInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226BB RID: 140987 RVA: 0x00BC9F34 File Offset: 0x00BC8134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartAppScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartAppScoreUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226BC RID: 140988 RVA: 0x00BC9F88 File Offset: 0x00BC8188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppScoreUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.AppScoreUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226BD RID: 140989 RVA: 0x00BC9FDC File Offset: 0x00BC81DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppScoreUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.AppScoreUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226BE RID: 140990 RVA: 0x00BCA038 File Offset: 0x00BC8238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppScoreUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.AppScoreUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226BF RID: 140991 RVA: 0x00BCA08C File Offset: 0x00BC828C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartSignUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartSignUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C0 RID: 140992 RVA: 0x00BCA0E0 File Offset: 0x00BC82E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SignUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.SignUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C1 RID: 140993 RVA: 0x00BCA134 File Offset: 0x00BC8334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartActivityNoticeUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartActivityNoticeUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C2 RID: 140994 RVA: 0x00BCA188 File Offset: 0x00BC8388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityNoticeUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ActivityNoticeUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C3 RID: 140995 RVA: 0x00BCA1DC File Offset: 0x00BC83DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 2, out fromIntent);
			worldUITask.m_luaExportHelper.StartHeroUITask(fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C4 RID: 140996 RVA: 0x00BCA238 File Offset: 0x00BC8438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.HeroUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C5 RID: 140997 RVA: 0x00BCA28C File Offset: 0x00BC848C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBagUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartBagUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C6 RID: 140998 RVA: 0x00BCA2E0 File Offset: 0x00BC84E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.BagUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C7 RID: 140999 RVA: 0x00BCA334 File Offset: 0x00BC8534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartMissionUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 2, out fromIntent);
			worldUITask.m_luaExportHelper.StartMissionUITask(fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C8 RID: 141000 RVA: 0x00BCA390 File Offset: 0x00BC8590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MissionUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.MissionUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226C9 RID: 141001 RVA: 0x00BCA3E4 File Offset: 0x00BC85E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartOpenServiceActivityUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartOpenServiceActivityUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226CA RID: 141002 RVA: 0x00BCA438 File Offset: 0x00BC8638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenServiceActivityUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.OpenServiceActivityUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226CB RID: 141003 RVA: 0x00BCA48C File Offset: 0x00BC868C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartFettersUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out heroDungeonLevelInfo);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartFettersUITask(heroDungeonLevelInfo, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226CC RID: 141004 RVA: 0x00BCA4F8 File Offset: 0x00BC86F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.FettersUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226CD RID: 141005 RVA: 0x00BCA554 File Offset: 0x00BC8754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.FettersUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226CE RID: 141006 RVA: 0x00BCA5A8 File Offset: 0x00BC87A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FetterUITask_StartHeroDungeon(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.FetterUITask_StartHeroDungeon(hero, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226CF RID: 141007 RVA: 0x00BCA614 File Offset: 0x00BC8814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaSelectUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaUIType arenaUIType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arenaUIType);
			bool isBattleReport;
			LuaObject.checkType(l, 3, out isBattleReport);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 4, out fromIntent);
			worldUITask.m_luaExportHelper.StartArenaSelectUITask(arenaUIType, isBattleReport, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D0 RID: 141008 RVA: 0x00BCA68C File Offset: 0x00BC888C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaSelectUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.ArenaSelectUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D1 RID: 141009 RVA: 0x00BCA6E8 File Offset: 0x00BC88E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaSelectUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ArenaSelectUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D2 RID: 141010 RVA: 0x00BCA73C File Offset: 0x00BC893C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaSelectUITask_OnShowArena(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaUIType arenaUIType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arenaUIType);
			bool isBattleReport;
			LuaObject.checkType(l, 3, out isBattleReport);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 4, out fromIntent);
			worldUITask.m_luaExportHelper.ArenaSelectUITask_OnShowArena(arenaUIType, isBattleReport, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D3 RID: 141011 RVA: 0x00BCA7B4 File Offset: 0x00BC89B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaUIType arenaUIType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arenaUIType);
			bool isBattleReport;
			LuaObject.checkType(l, 3, out isBattleReport);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 4, out fromIntent);
			worldUITask.m_luaExportHelper.StartArenaUITask(arenaUIType, isBattleReport, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D4 RID: 141012 RVA: 0x00BCA82C File Offset: 0x00BC8A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ArenaUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D5 RID: 141013 RVA: 0x00BCA880 File Offset: 0x00BC8A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.ArenaUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D6 RID: 141014 RVA: 0x00BCA8DC File Offset: 0x00BC8ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUITask_OnStartArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool isRevenge;
			LuaObject.checkType(l, 2, out isRevenge);
			worldUITask.m_luaExportHelper.ArenaUITask_OnStartArenaBattle(isRevenge);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D7 RID: 141015 RVA: 0x00BCA938 File Offset: 0x00BC8B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUITask_OnStartArenaBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaBattleReport battleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
			worldUITask.m_luaExportHelper.ArenaUITask_OnStartArenaBattleReplay(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D8 RID: 141016 RVA: 0x00BCA994 File Offset: 0x00BC8B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUITask_OnStartRealTimePVPBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			RealTimePVPBattleReport battleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out battleReport);
			worldUITask.m_luaExportHelper.ArenaUITask_OnStartRealTimePVPBattleReplay(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226D9 RID: 141017 RVA: 0x00BCA9F0 File Offset: 0x00BC8BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAndStartArenaUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaUIType arenaUIType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arenaUIType);
			bool isBattleReport;
			LuaObject.checkType(l, 3, out isBattleReport);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 4, out fromIntent);
			worldUITask.m_luaExportHelper.InitAndStartArenaUITask(arenaUIType, isBattleReport, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226DA RID: 141018 RVA: 0x00BCAA68 File Offset: 0x00BC8C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattleReportBasicDataGetNetTask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaUIType arenaUIType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arenaUIType);
			bool isBattleReport;
			LuaObject.checkType(l, 3, out isBattleReport);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 4, out fromIntent);
			worldUITask.m_luaExportHelper.StartArenaBattleReportBasicDataGetNetTask(arenaUIType, isBattleReport, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226DB RID: 141019 RVA: 0x00BCAAE0 File Offset: 0x00BC8CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartStoreUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			StoreId storeId;
			LuaObject.checkEnum<StoreId>(l, 2, out storeId);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartStoreUITask(storeId, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226DC RID: 141020 RVA: 0x00BCAB4C File Offset: 0x00BC8D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StoreUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226DD RID: 141021 RVA: 0x00BCABA0 File Offset: 0x00BC8DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartSelectCardUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartSelectCardUITask(cardPoolId, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226DE RID: 141022 RVA: 0x00BCAC0C File Offset: 0x00BC8E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.SelectCardUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226DF RID: 141023 RVA: 0x00BCAC60 File Offset: 0x00BC8E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartDrillUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int drillState;
			LuaObject.checkType(l, 2, out drillState);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartDrillUITask(drillState, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E0 RID: 141024 RVA: 0x00BCACCC File Offset: 0x00BC8ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrillUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.DrillUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E1 RID: 141025 RVA: 0x00BCAD20 File Offset: 0x00BC8F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartFriendUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 2, out fromIntent);
			worldUITask.m_luaExportHelper.StartFriendUITask(fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E2 RID: 141026 RVA: 0x00BCAD7C File Offset: 0x00BC8F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGuildUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 2, out fromIntent);
			bool goToGuildMassiveCombat;
			LuaObject.checkType(l, 3, out goToGuildMassiveCombat);
			worldUITask.m_luaExportHelper.StartGuildUITask(fromIntent, goToGuildMassiveCombat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E3 RID: 141027 RVA: 0x00BCADE8 File Offset: 0x00BC8FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.FriendUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E4 RID: 141028 RVA: 0x00BCAE3C File Offset: 0x00BC903C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartMailUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartMailUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E5 RID: 141029 RVA: 0x00BCAE90 File Offset: 0x00BC9090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRankingUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartRankingUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E6 RID: 141030 RVA: 0x00BCAEE4 File Offset: 0x00BC90E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartActivityUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			worldUITask.m_luaExportHelper.StartActivityUITask(activityId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E7 RID: 141031 RVA: 0x00BCAF40 File Offset: 0x00BC9140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ActivityUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E8 RID: 141032 RVA: 0x00BCAF94 File Offset: 0x00BC9194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTeamUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartTeamUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226E9 RID: 141033 RVA: 0x00BCAFE8 File Offset: 0x00BC91E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226EA RID: 141034 RVA: 0x00BCB03C File Offset: 0x00BC923C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTestUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartTestUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226EB RID: 141035 RVA: 0x00BCB090 File Offset: 0x00BC9290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.TestUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226EC RID: 141036 RVA: 0x00BCB0EC File Offset: 0x00BC92EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.TestUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226ED RID: 141037 RVA: 0x00BCB140 File Offset: 0x00BC9340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUITask_OnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			worldUITask.m_luaExportHelper.TestUITask_OnStartBattle(battleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226EE RID: 141038 RVA: 0x00BCB19C File Offset: 0x00BC939C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUnchartedUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			int tabIndex;
			LuaObject.checkType(l, 4, out tabIndex);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 5, out fromIntent);
			worldUITask.m_luaExportHelper.StartUnchartedUITask(battleType, chapterId, tabIndex, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226EF RID: 141039 RVA: 0x00BCB220 File Offset: 0x00BC9420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.UnchartedUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F0 RID: 141040 RVA: 0x00BCB27C File Offset: 0x00BC947C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UnchartedUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F1 RID: 141041 RVA: 0x00BCB2D0 File Offset: 0x00BC94D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _StartUnchartedSubUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 4, out fromIntent);
			worldUITask.m_luaExportHelper._StartUnchartedSubUITask(battleType, chapterId, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F2 RID: 141042 RVA: 0x00BCB348 File Offset: 0x00BC9548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRiftUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			bool openLevelInfo;
			LuaObject.checkType(l, 3, out openLevelInfo);
			bool needReturnToChapter;
			LuaObject.checkType(l, 4, out needReturnToChapter);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 5, out fromIntent);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 6, out needGoods);
			worldUITask.m_luaExportHelper.StartRiftUITask(levelInfo, openLevelInfo, needReturnToChapter, fromIntent, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F3 RID: 141043 RVA: 0x00BCB3D8 File Offset: 0x00BC95D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.RiftUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F4 RID: 141044 RVA: 0x00BCB434 File Offset: 0x00BC9634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.RiftUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F5 RID: 141045 RVA: 0x00BCB488 File Offset: 0x00BC9688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftUITask_GoToScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int scenarioID;
			LuaObject.checkType(l, 2, out scenarioID);
			worldUITask.m_luaExportHelper.RiftUITask_GoToScenario(scenarioID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F6 RID: 141046 RVA: 0x00BCB4E4 File Offset: 0x00BC96E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroDungeonUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			bool openLevelInfo;
			LuaObject.checkType(l, 3, out openLevelInfo);
			Hero hero;
			LuaObject.checkType<Hero>(l, 4, out hero);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 5, out fromIntent);
			worldUITask.m_luaExportHelper.StartHeroDungeonUITask(levelInfo, openLevelInfo, hero, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F7 RID: 141047 RVA: 0x00BCB568 File Offset: 0x00BC9768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDungeonUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.HeroDungeonUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F8 RID: 141048 RVA: 0x00BCB5BC File Offset: 0x00BC97BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroPhantomUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantomInfo;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out heroPhantomInfo);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartHeroPhantomUITask(heroPhantomInfo, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226F9 RID: 141049 RVA: 0x00BCB628 File Offset: 0x00BC9828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroPhantomUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.HeroPhantomUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226FA RID: 141050 RVA: 0x00BCB67C File Offset: 0x00BC987C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartThearchyUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialInfo thearchyTrialInfo;
			LuaObject.checkType<ConfigDataThearchyTrialInfo>(l, 2, out thearchyTrialInfo);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartThearchyUITask(thearchyTrialInfo, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226FB RID: 141051 RVA: 0x00BCB6E8 File Offset: 0x00BC98E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ThearchyUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ThearchyUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226FC RID: 141052 RVA: 0x00BCB73C File Offset: 0x00BC993C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartAnikiUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out anikiGymInfo);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartAnikiUITask(anikiGymInfo, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226FD RID: 141053 RVA: 0x00BCB7A8 File Offset: 0x00BC99A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.AnikiUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226FE RID: 141054 RVA: 0x00BCB7FC File Offset: 0x00BC99FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTreasureMapUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 2, out fromIntent);
			worldUITask.m_luaExportHelper.StartTreasureMapUITask(fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060226FF RID: 141055 RVA: 0x00BCB858 File Offset: 0x00BC9A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TreasureMapUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.TreasureMapUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022700 RID: 141056 RVA: 0x00BCB8AC File Offset: 0x00BC9AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartMemoryCorridorUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorInfo memoryCorridorInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorInfo>(l, 2, out memoryCorridorInfo);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartMemoryCorridorUITask(memoryCorridorInfo, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022701 RID: 141057 RVA: 0x00BCB918 File Offset: 0x00BC9B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MemoryCorridorUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.MemoryCorridorUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022702 RID: 141058 RVA: 0x00BCB96C File Offset: 0x00BC9B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroTrainningUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningInfo heroTrainningInfo;
			LuaObject.checkType<ConfigDataHeroTrainningInfo>(l, 2, out heroTrainningInfo);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartHeroTrainningUITask(heroTrainningInfo, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022703 RID: 141059 RVA: 0x00BCB9D8 File Offset: 0x00BC9BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroTrainningUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.HeroTrainningUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022704 RID: 141060 RVA: 0x00BCBA2C File Offset: 0x00BC9C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCooperateBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleInfo cooperateBattleInfo;
			LuaObject.checkType<ConfigDataCooperateBattleInfo>(l, 2, out cooperateBattleInfo);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			worldUITask.m_luaExportHelper.StartCooperateBattleUITask(cooperateBattleInfo, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022705 RID: 141061 RVA: 0x00BCBA98 File Offset: 0x00BC9C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CooperateBattleUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.CooperateBattleUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022706 RID: 141062 RVA: 0x00BCBAEC File Offset: 0x00BC9CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUnchartedScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 3, out battleType);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 4, out fromIntent);
			worldUITask.m_luaExportHelper.StartUnchartedScoreUITask(unchartedScoreInfo, battleType, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022707 RID: 141063 RVA: 0x00BCBB64 File Offset: 0x00BC9D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedScoreUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.UnchartedScoreUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022708 RID: 141064 RVA: 0x00BCBBB8 File Offset: 0x00BC9DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartClimbTowerUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 2, out fromIntent);
			worldUITask.m_luaExportHelper.StartClimbTowerUITask(fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022709 RID: 141065 RVA: 0x00BCBC14 File Offset: 0x00BC9E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.ClimbTowerUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602270A RID: 141066 RVA: 0x00BCBC68 File Offset: 0x00BC9E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartWorldEventMissionUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			worldUITask.m_luaExportHelper.StartWorldEventMissionUITask(eventInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602270B RID: 141067 RVA: 0x00BCBCC4 File Offset: 0x00BC9EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldEventMissionUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			worldUITask.m_luaExportHelper.WorldEventMissionUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602270C RID: 141068 RVA: 0x00BCBD20 File Offset: 0x00BC9F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldEventMissionUITask_OnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldEventMissionUITask_OnEnterMission();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602270D RID: 141069 RVA: 0x00BCBD74 File Offset: 0x00BC9F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldEventMissionUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.WorldEventMissionUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602270E RID: 141070 RVA: 0x00BCBDC8 File Offset: 0x00BC9FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGoddessDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.StartGoddessDialogUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602270F RID: 141071 RVA: 0x00BCBE1C File Offset: 0x00BCA01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.GoddessDialogUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022710 RID: 141072 RVA: 0x00BCBE70 File Offset: 0x00BCA070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoddessDialogUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int protagonistId;
			LuaObject.checkType(l, 2, out protagonistId);
			worldUITask.m_luaExportHelper.GoddessDialogUITask_OnClose(protagonistId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022711 RID: 141073 RVA: 0x00BCBECC File Offset: 0x00BCA0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			worldUITask.m_luaExportHelper.StartDialogUITask(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022712 RID: 141074 RVA: 0x00BCBF28 File Offset: 0x00BCA128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DialogUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.DialogUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022713 RID: 141075 RVA: 0x00BCBF7C File Offset: 0x00BCA17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DialogUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool isSkip;
			LuaObject.checkType(l, 2, out isSkip);
			worldUITask.m_luaExportHelper.DialogUITask_OnClose(isSkip);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022714 RID: 141076 RVA: 0x00BCBFD8 File Offset: 0x00BCA1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 3, out battleType);
			worldUITask.m_luaExportHelper.StartBattleUITask(battleInfo, battleType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022715 RID: 141077 RVA: 0x00BCC044 File Offset: 0x00BCA244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool isRevenge;
			LuaObject.checkType(l, 2, out isRevenge);
			worldUITask.m_luaExportHelper.StartArenaBattleUITask(isRevenge);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022716 RID: 141078 RVA: 0x00BCC0A0 File Offset: 0x00BCA2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaReplayBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaBattleReport battleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
			worldUITask.m_luaExportHelper.StartArenaReplayBattleUITask(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022717 RID: 141079 RVA: 0x00BCC0FC File Offset: 0x00BCA2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRealTimePVPReplayBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			RealTimePVPBattleReport battleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out battleReport);
			worldUITask.m_luaExportHelper.StartRealTimePVPReplayBattleUITask(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022718 RID: 141080 RVA: 0x00BCC158 File Offset: 0x00BCA358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeOutAndStartBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.FadeOutAndStartBattleUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022719 RID: 141081 RVA: 0x00BCC1AC File Offset: 0x00BCA3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _StartGetPathTargetUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 2, out getPath);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 4, out needGoods);
			worldUITask.m_luaExportHelper._StartGetPathTargetUITask(getPath, fromIntent, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602271A RID: 141082 RVA: 0x00BCC224 File Offset: 0x00BCA424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602271B RID: 141083 RVA: 0x00BCC28C File Offset: 0x00BCA48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602271C RID: 141084 RVA: 0x00BCC2E0 File Offset: 0x00BCA4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602271D RID: 141085 RVA: 0x00BCC334 File Offset: 0x00BCA534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0602271E RID: 141086 RVA: 0x00BCC39C File Offset: 0x00BCA59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0602271F RID: 141087 RVA: 0x00BCC404 File Offset: 0x00BCA604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			worldUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022720 RID: 141088 RVA: 0x00BCC470 File Offset: 0x00BCA670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06022721 RID: 141089 RVA: 0x00BCC4CC File Offset: 0x00BCA6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			List<string> o = worldUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06022722 RID: 141090 RVA: 0x00BCC528 File Offset: 0x00BCA728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022723 RID: 141091 RVA: 0x00BCC57C File Offset: 0x00BCA77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022724 RID: 141092 RVA: 0x00BCC5D0 File Offset: 0x00BCA7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022725 RID: 141093 RVA: 0x00BCC624 File Offset: 0x00BCA824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022726 RID: 141094 RVA: 0x00BCC678 File Offset: 0x00BCA878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022727 RID: 141095 RVA: 0x00BCC6CC File Offset: 0x00BCA8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			worldUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022728 RID: 141096 RVA: 0x00BCC728 File Offset: 0x00BCA928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			worldUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022729 RID: 141097 RVA: 0x00BCC784 File Offset: 0x00BCA984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			worldUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602272A RID: 141098 RVA: 0x00BCC7E0 File Offset: 0x00BCA9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			worldUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602272B RID: 141099 RVA: 0x00BCC83C File Offset: 0x00BCAA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602272C RID: 141100 RVA: 0x00BCC898 File Offset: 0x00BCAA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602272D RID: 141101 RVA: 0x00BCC8F4 File Offset: 0x00BCAAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool b = worldUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0602272E RID: 141102 RVA: 0x00BCC950 File Offset: 0x00BCAB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UITaskBase o = worldUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602272F RID: 141103 RVA: 0x00BCC9AC File Offset: 0x00BCABAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022730 RID: 141104 RVA: 0x00BCCA00 File Offset: 0x00BCAC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			worldUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022731 RID: 141105 RVA: 0x00BCCA54 File Offset: 0x00BCAC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopSubUITask_s(IntPtr l)
	{
		int result;
		try
		{
			Type taskType;
			LuaObject.checkType(l, 1, out taskType);
			WorldUITask.LuaExportHelper.StopSubUITask(taskType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022732 RID: 141106 RVA: 0x00BCCAA0 File Offset: 0x00BCACA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleArmyRandomSeedGetNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			int battleId;
			LuaObject.checkType(l, 1, out battleId);
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 2, out onEnd);
			WorldUITask.LuaExportHelper.StartBattleArmyRandomSeedGetNetTask(battleId, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022733 RID: 141107 RVA: 0x00BCCAF8 File Offset: 0x00BCACF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartDanmakuGetNetTaskNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 1, out onEnd);
			WorldUITask.LuaExportHelper.StartDanmakuGetNetTaskNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022734 RID: 141108 RVA: 0x00BCCB44 File Offset: 0x00BCAD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideInviteAndChatUITask_s(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask.LuaExportHelper.HideInviteAndChatUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022735 RID: 141109 RVA: 0x00BCCB84 File Offset: 0x00BCAD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnloadAssetsAndStartBattleUITask_s(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask.LuaExportHelper.UnloadAssetsAndStartBattleUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022736 RID: 141110 RVA: 0x00BCCBC4 File Offset: 0x00BCADC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_UnloadAssetsAndStartBattleUITask_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator o = WorldUITask.LuaExportHelper.Co_UnloadAssetsAndStartBattleUITask();
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

	// Token: 0x06022737 RID: 141111 RVA: 0x00BCCC0C File Offset: 0x00BCAE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask.LuaExportHelper.BattleUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022738 RID: 141112 RVA: 0x00BCCC4C File Offset: 0x00BCAE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022739 RID: 141113 RVA: 0x00BCCCA4 File Offset: 0x00BCAEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			worldUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602273A RID: 141114 RVA: 0x00BCCD00 File Offset: 0x00BCAF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602273B RID: 141115 RVA: 0x00BCCD58 File Offset: 0x00BCAF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			worldUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602273C RID: 141116 RVA: 0x00BCCDB4 File Offset: 0x00BCAFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, WorldUITask.LuaExportHelper.s_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602273D RID: 141117 RVA: 0x00BCCDFC File Offset: 0x00BCAFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_instance(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask s_instance;
			LuaObject.checkType<WorldUITask>(l, 2, out s_instance);
			WorldUITask.LuaExportHelper.s_instance = s_instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602273E RID: 141118 RVA: 0x00BCCE48 File Offset: 0x00BCB048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_isShowWorldUI(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, WorldUITask.LuaExportHelper.s_isShowWorldUI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602273F RID: 141119 RVA: 0x00BCCE90 File Offset: 0x00BCB090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_isShowWorldUI(IntPtr l)
	{
		int result;
		try
		{
			bool s_isShowWorldUI;
			LuaObject.checkType(l, 2, out s_isShowWorldUI);
			WorldUITask.LuaExportHelper.s_isShowWorldUI = s_isShowWorldUI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022740 RID: 141120 RVA: 0x00BCCEDC File Offset: 0x00BCB0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_worldUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022741 RID: 141121 RVA: 0x00BCCF34 File Offset: 0x00BCB134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			WorldUIController worldUIController;
			LuaObject.checkType<WorldUIController>(l, 2, out worldUIController);
			worldUITask.m_luaExportHelper.m_worldUIController = worldUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022742 RID: 141122 RVA: 0x00BCCF90 File Offset: 0x00BCB190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldMapUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_worldMapUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022743 RID: 141123 RVA: 0x00BCCFE8 File Offset: 0x00BCB1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldMapUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			WorldMapUIController worldMapUIController;
			LuaObject.checkType<WorldMapUIController>(l, 2, out worldMapUIController);
			worldUITask.m_luaExportHelper.m_worldMapUIController = worldMapUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022744 RID: 141124 RVA: 0x00BCD044 File Offset: 0x00BCB244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022745 RID: 141125 RVA: 0x00BCD09C File Offset: 0x00BCB29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			worldUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022746 RID: 141126 RVA: 0x00BCD0F8 File Offset: 0x00BCB2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_chestUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022747 RID: 141127 RVA: 0x00BCD150 File Offset: 0x00BCB350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ChestUITask chestUITask;
			LuaObject.checkType<ChestUITask>(l, 2, out chestUITask);
			worldUITask.m_luaExportHelper.m_chestUITask = chestUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022748 RID: 141128 RVA: 0x00BCD1AC File Offset: 0x00BCB3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_getRewardGoodsUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022749 RID: 141129 RVA: 0x00BCD204 File Offset: 0x00BCB404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			GetRewardGoodsUITask getRewardGoodsUITask;
			LuaObject.checkType<GetRewardGoodsUITask>(l, 2, out getRewardGoodsUITask);
			worldUITask.m_luaExportHelper.m_getRewardGoodsUITask = getRewardGoodsUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602274A RID: 141130 RVA: 0x00BCD260 File Offset: 0x00BCB460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_fettersUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602274B RID: 141131 RVA: 0x00BCD2B8 File Offset: 0x00BCB4B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fettersUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			FettersUITask fettersUITask;
			LuaObject.checkType<FettersUITask>(l, 2, out fettersUITask);
			worldUITask.m_luaExportHelper.m_fettersUITask = fettersUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602274C RID: 141132 RVA: 0x00BCD314 File Offset: 0x00BCB514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_riftUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602274D RID: 141133 RVA: 0x00BCD36C File Offset: 0x00BCB56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			RiftUITask riftUITask;
			LuaObject.checkType<RiftUITask>(l, 2, out riftUITask);
			worldUITask.m_luaExportHelper.m_riftUITask = riftUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602274E RID: 141134 RVA: 0x00BCD3C8 File Offset: 0x00BCB5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_unchartedUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602274F RID: 141135 RVA: 0x00BCD420 File Offset: 0x00BCB620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			UnchartedUITask unchartedUITask;
			LuaObject.checkType<UnchartedUITask>(l, 2, out unchartedUITask);
			worldUITask.m_luaExportHelper.m_unchartedUITask = unchartedUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022750 RID: 141136 RVA: 0x00BCD47C File Offset: 0x00BCB67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaSelectUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_arenaSelectUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022751 RID: 141137 RVA: 0x00BCD4D4 File Offset: 0x00BCB6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaSelectUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaSelectUITask arenaSelectUITask;
			LuaObject.checkType<ArenaSelectUITask>(l, 2, out arenaSelectUITask);
			worldUITask.m_luaExportHelper.m_arenaSelectUITask = arenaSelectUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022752 RID: 141138 RVA: 0x00BCD530 File Offset: 0x00BCB730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_arenaUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_arenaUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022753 RID: 141139 RVA: 0x00BCD588 File Offset: 0x00BCB788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ArenaUITask arenaUITask;
			LuaObject.checkType<ArenaUITask>(l, 2, out arenaUITask);
			worldUITask.m_luaExportHelper.m_arenaUITask = arenaUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022754 RID: 141140 RVA: 0x00BCD5E4 File Offset: 0x00BCB7E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_playerInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022755 RID: 141141 RVA: 0x00BCD63C File Offset: 0x00BCB83C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			PlayerInfoUITask playerInfoUITask;
			LuaObject.checkType<PlayerInfoUITask>(l, 2, out playerInfoUITask);
			worldUITask.m_luaExportHelper.m_playerInfoUITask = playerInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022756 RID: 141142 RVA: 0x00BCD698 File Offset: 0x00BCB898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_appScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_appScoreUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022757 RID: 141143 RVA: 0x00BCD6F0 File Offset: 0x00BCB8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_appScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			AppScoreUITask appScoreUITask;
			LuaObject.checkType<AppScoreUITask>(l, 2, out appScoreUITask);
			worldUITask.m_luaExportHelper.m_appScoreUITask = appScoreUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022758 RID: 141144 RVA: 0x00BCD74C File Offset: 0x00BCB94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_testUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022759 RID: 141145 RVA: 0x00BCD7A4 File Offset: 0x00BCB9A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_testUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			TestUITask testUITask;
			LuaObject.checkType<TestUITask>(l, 2, out testUITask);
			worldUITask.m_luaExportHelper.m_testUITask = testUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602275A RID: 141146 RVA: 0x00BCD800 File Offset: 0x00BCBA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldEventMissionUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_worldEventMissionUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602275B RID: 141147 RVA: 0x00BCD858 File Offset: 0x00BCBA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldEventMissionUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			WorldEventMissionUITask worldEventMissionUITask;
			LuaObject.checkType<WorldEventMissionUITask>(l, 2, out worldEventMissionUITask);
			worldUITask.m_luaExportHelper.m_worldEventMissionUITask = worldEventMissionUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602275C RID: 141148 RVA: 0x00BCD8B4 File Offset: 0x00BCBAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_dialogUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602275D RID: 141149 RVA: 0x00BCD90C File Offset: 0x00BCBB0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dialogUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			DialogUITask dialogUITask;
			LuaObject.checkType<DialogUITask>(l, 2, out dialogUITask);
			worldUITask.m_luaExportHelper.m_dialogUITask = dialogUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602275E RID: 141150 RVA: 0x00BCD968 File Offset: 0x00BCBB68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_goddessDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_goddessDialogUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602275F RID: 141151 RVA: 0x00BCD9C0 File Offset: 0x00BCBBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goddessDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			GoddessDialogUITask goddessDialogUITask;
			LuaObject.checkType<GoddessDialogUITask>(l, 2, out goddessDialogUITask);
			worldUITask.m_luaExportHelper.m_goddessDialogUITask = goddessDialogUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022760 RID: 141152 RVA: 0x00BCDA1C File Offset: 0x00BCBC1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_clientWorld);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022761 RID: 141153 RVA: 0x00BCDA74 File Offset: 0x00BCBC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ClientWorld clientWorld;
			LuaObject.checkType<ClientWorld>(l, 2, out clientWorld);
			worldUITask.m_luaExportHelper.m_clientWorld = clientWorld;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022762 RID: 141154 RVA: 0x00BCDAD0 File Offset: 0x00BCBCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022763 RID: 141155 RVA: 0x00BCDB28 File Offset: 0x00BCBD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			worldUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022764 RID: 141156 RVA: 0x00BCDB84 File Offset: 0x00BCBD84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022765 RID: 141157 RVA: 0x00BCDBDC File Offset: 0x00BCBDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			worldUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022766 RID: 141158 RVA: 0x00BCDC38 File Offset: 0x00BCBE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022767 RID: 141159 RVA: 0x00BCDC90 File Offset: 0x00BCBE90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			worldUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022768 RID: 141160 RVA: 0x00BCDCEC File Offset: 0x00BCBEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isResuming(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_isResuming);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022769 RID: 141161 RVA: 0x00BCDD44 File Offset: 0x00BCBF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isResuming(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool isResuming;
			LuaObject.checkType(l, 2, out isResuming);
			worldUITask.m_luaExportHelper.m_isResuming = isResuming;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602276A RID: 141162 RVA: 0x00BCDDA0 File Offset: 0x00BCBFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isResumeNeedNextWorldStep(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_isResumeNeedNextWorldStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602276B RID: 141163 RVA: 0x00BCDDF8 File Offset: 0x00BCBFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isResumeNeedNextWorldStep(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			bool isResumeNeedNextWorldStep;
			LuaObject.checkType(l, 2, out isResumeNeedNextWorldStep);
			worldUITask.m_luaExportHelper.m_isResumeNeedNextWorldStep = isResumeNeedNextWorldStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602276C RID: 141164 RVA: 0x00BCDE54 File Offset: 0x00BCC054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_showMainButtonBar(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, WorldUITask.LuaExportHelper.s_showMainButtonBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602276D RID: 141165 RVA: 0x00BCDE9C File Offset: 0x00BCC09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_showMainButtonBar(IntPtr l)
	{
		int result;
		try
		{
			bool s_showMainButtonBar;
			LuaObject.checkType(l, 2, out s_showMainButtonBar);
			WorldUITask.LuaExportHelper.s_showMainButtonBar = s_showMainButtonBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602276E RID: 141166 RVA: 0x00BCDEE8 File Offset: 0x00BCC0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_movePath(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.m_movePath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602276F RID: 141167 RVA: 0x00BCDF40 File Offset: 0x00BCC140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_movePath(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			List<int> movePath;
			LuaObject.checkType<List<int>>(l, 2, out movePath);
			worldUITask.m_luaExportHelper.m_movePath = movePath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022770 RID: 141168 RVA: 0x00BCDF9C File Offset: 0x00BCC19C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022771 RID: 141169 RVA: 0x00BCDFF4 File Offset: 0x00BCC1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldUITask worldUITask = (WorldUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022772 RID: 141170 RVA: 0x00BCE04C File Offset: 0x00BCC24C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldUITask");
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowActivityNotice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.GetClientWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnWaypointClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnScreenEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_ShowHide_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ShowWorld_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartBattleHappening_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HandleAttackFailResult_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartUnchartedSubUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartGetPathTargetUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CollectPlayerAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CollectEventAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CollectMonthCardAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HideAllView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.InitWorldMapUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UninitWorldMapUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.InitWorldUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UninitWorldUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateRedMarks);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdatePlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateHeroRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateMissionRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateActivityRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateFriendRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateDrillRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateFetterRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateGuildRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateWorldEventRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateInvestigationButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateOpenServiceActivityButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateCooperateBattleButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateMonthCardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnSlowTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ShowEventList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HasRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateNewChatCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UpdateNewMailCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CreateClientWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.DestroyClientWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartClientWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.NextWorldStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIGetReady);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ClickFirstWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartSetProtagonistNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowMainButtonBar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnCompass);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnUnlockScenarioGotoRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnGotoEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnStartPastScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnClosePastScenarioList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowDrill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowUncharted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowRift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowCooperateBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowRanking);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnShowOpenServiceActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnMonthCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnRefreshMonthCardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnMonthCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnMonthCardItemBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnOpenWebInvestigation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnYYBButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldUIController_OnOppoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PDSDK_OnDoQuestionSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PDSDK_OnDoQuestionFailed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.GetRewardGoodsUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.GetRewardGoodsUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ChestUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ChestUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldMapUIController_OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldMapUIController_OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldMapUIController_OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerResourceUIController_OnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerResourceUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnMailsChangedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnFriendInviteNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnFriendInviteAcceptNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnFriendshipPointsReceivedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_EventOnGiftStoreBuyGoodsNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnChatMessageNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnMailReadAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnPlayerInfoChangeNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnTeamRoomInviteNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnBattlePracticeInvitedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnBattleRoomTeamBattleJoinNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnBattleRoomPVPBattleJoinNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnBattleRoomRealTimePVPBattleJoinNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnBattleRoomGuildMassiveCombatBattleJoinNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerContext_OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartWaypointEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartBattleRoomBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask._StartBattleHappening);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartHappening);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.NextHappeningStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartLevelWayPointMoveNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartLevelScenarioHandleNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OnLevelWayPointMoveNetTaskResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ShowWaypointReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CheckChangeCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.Co_ChangeCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CheckOpenRiftChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CheckOrderReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CheckReturnToBeforeBattleUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CheckOpenTeamRoomInfoUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartTeamRoomInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CheckInBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.MoveToPrevWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerArriveWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ShowPastScenarioList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartShowFadeOutLoadingFadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HideFadeOutLoadingFadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartPlayerInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerInfoUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerInfoUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.PlayerInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartAppScoreUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.AppScoreUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.AppScoreUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.AppScoreUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartSignUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.SignUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartActivityNoticeUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ActivityNoticeUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartHeroUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HeroUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartBagUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.BagUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartMissionUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.MissionUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartOpenServiceActivityUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.OpenServiceActivityUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA0);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartFettersUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA1);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.FettersUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA2);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.FettersUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA3);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.FetterUITask_StartHeroDungeon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA4);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartArenaSelectUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA5);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaSelectUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA6);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaSelectUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA7);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaSelectUITask_OnShowArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA8);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartArenaUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheA9);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAA);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAB);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaUITask_OnStartArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAC);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaUITask_OnStartArenaBattleReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAD);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ArenaUITask_OnStartRealTimePVPBattleReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAE);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.InitAndStartArenaUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheAF);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartArenaBattleReportBasicDataGetNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB0);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartStoreUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB1);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StoreUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB2);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartSelectCardUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB3);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.SelectCardUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB4);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartDrillUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB5);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.DrillUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB6);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartFriendUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB7);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartGuildUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB8);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.FriendUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheB9);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartMailUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBA);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartRankingUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBB);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartActivityUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBC);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ActivityUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBD);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartTeamUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBE);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheBF);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartTestUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC0);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.TestUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC1);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.TestUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC2);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.TestUITask_OnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC3);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartUnchartedUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC4);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UnchartedUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC5);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UnchartedUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC6);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask._StartUnchartedSubUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC7);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartRiftUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC8);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.RiftUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheC9);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.RiftUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCA);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.RiftUITask_GoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCB);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartHeroDungeonUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCC);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HeroDungeonUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCD);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartHeroPhantomUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCE);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HeroPhantomUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheCF);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartThearchyUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD0);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ThearchyUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD1);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartAnikiUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD2);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.AnikiUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD3);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartTreasureMapUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD4);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.TreasureMapUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD5);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartMemoryCorridorUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD6);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.MemoryCorridorUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD7);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartHeroTrainningUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD8);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HeroTrainningUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheD9);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartCooperateBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDA);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.CooperateBattleUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDB);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartUnchartedScoreUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDC);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UnchartedScoreUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDD);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartClimbTowerUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDE);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.ClimbTowerUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheDF);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartWorldEventMissionUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE0);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldEventMissionUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE1);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldEventMissionUITask_OnEnterMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE2);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.WorldEventMissionUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE3);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartGoddessDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE4);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.GoddessDialogUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE5);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.GoddessDialogUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE6);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE7);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.DialogUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE8);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.DialogUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheE9);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEA);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartArenaBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEB);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartArenaReplayBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEC);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartRealTimePVPReplayBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheED);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.FadeOutAndStartBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEE);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask._StartGetPathTargetUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheEF);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF0);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF1);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF2);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF3);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF4);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF5);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF6);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF7);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF8);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheF9);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFA);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFB);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFC);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFD);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFE);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cacheFF);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache100);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache101);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache102);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache103);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache104);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache105);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache106);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StopSubUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache107);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartBattleArmyRandomSeedGetNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache108);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.StartDanmakuGetNetTaskNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache109);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.HideInviteAndChatUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10A);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.UnloadAssetsAndStartBattleUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10B);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.Co_UnloadAssetsAndStartBattleUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10C);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.BattleUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10D);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10E;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache10F, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache110;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache111, true);
		string name3 = "s_instance";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_s_instance);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache112;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_s_instance);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache113, false);
		string name4 = "s_isShowWorldUI";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_s_isShowWorldUI);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache114;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_s_isShowWorldUI);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache115, false);
		string name5 = "m_worldUIController";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_worldUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache116;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_worldUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache117, true);
		string name6 = "m_worldMapUIController";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_worldMapUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache118;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_worldMapUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache119, true);
		string name7 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11A;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11B, true);
		string name8 = "m_chestUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_chestUITask);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11C;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_chestUITask);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11D, true);
		string name9 = "m_getRewardGoodsUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_getRewardGoodsUITask);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11E;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_getRewardGoodsUITask);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache11F, true);
		string name10 = "m_fettersUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_fettersUITask);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache120;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_fettersUITask);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache121, true);
		string name11 = "m_riftUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_riftUITask);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache122;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_riftUITask);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache123, true);
		string name12 = "m_unchartedUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_unchartedUITask);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache124;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_unchartedUITask);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache125, true);
		string name13 = "m_arenaSelectUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_arenaSelectUITask);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache126;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_arenaSelectUITask);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache127, true);
		string name14 = "m_arenaUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_arenaUITask);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache128;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_arenaUITask);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache129, true);
		string name15 = "m_playerInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_playerInfoUITask);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12A;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_playerInfoUITask);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12B, true);
		string name16 = "m_appScoreUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_appScoreUITask);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12C;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_appScoreUITask);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12D, true);
		string name17 = "m_testUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_testUITask);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12E;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_testUITask);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache12F, true);
		string name18 = "m_worldEventMissionUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_worldEventMissionUITask);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache130;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_worldEventMissionUITask);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache131, true);
		string name19 = "m_dialogUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_dialogUITask);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache132;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_dialogUITask);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache133, true);
		string name20 = "m_goddessDialogUITask";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_goddessDialogUITask);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache134;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_goddessDialogUITask);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache135, true);
		string name21 = "m_clientWorld";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_clientWorld);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_clientWorld);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache137, true);
		string name22 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_configDataLoader);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache139, true);
		string name23 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_playerContext);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13B, true);
		string name24 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_nowSeconds);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13C;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13D, true);
		string name25 = "m_isResuming";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_isResuming);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13E;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_isResuming);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache13F, true);
		string name26 = "m_isResumeNeedNextWorldStep";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_isResumeNeedNextWorldStep);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache140;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_isResumeNeedNextWorldStep);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache141, true);
		string name27 = "s_showMainButtonBar";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_s_showMainButtonBar);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache142;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_s_showMainButtonBar);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache143, false);
		string name28 = "m_movePath";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_m_movePath);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache144;
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.set_m_movePath);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache145, true);
		string name29 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache146, null, true);
		string name30 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache147, null, true);
		if (Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_WorldUITask.<>f__mg$cache148, typeof(WorldUITask), typeof(UITask));
	}

	// Token: 0x04018437 RID: 99383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018438 RID: 99384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018439 RID: 99385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401843A RID: 99386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401843B RID: 99387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401843C RID: 99388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401843D RID: 99389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401843E RID: 99390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401843F RID: 99391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018440 RID: 99392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018441 RID: 99393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018442 RID: 99394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018443 RID: 99395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018444 RID: 99396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018445 RID: 99397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018446 RID: 99398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018447 RID: 99399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018448 RID: 99400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018449 RID: 99401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401844A RID: 99402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401844B RID: 99403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401844C RID: 99404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401844D RID: 99405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401844E RID: 99406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401844F RID: 99407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018450 RID: 99408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018451 RID: 99409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018452 RID: 99410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018453 RID: 99411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018454 RID: 99412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018455 RID: 99413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018456 RID: 99414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018457 RID: 99415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018458 RID: 99416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018459 RID: 99417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401845A RID: 99418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401845B RID: 99419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401845C RID: 99420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401845D RID: 99421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401845E RID: 99422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401845F RID: 99423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018460 RID: 99424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018461 RID: 99425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018462 RID: 99426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018463 RID: 99427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018464 RID: 99428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018465 RID: 99429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018466 RID: 99430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018467 RID: 99431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018468 RID: 99432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018469 RID: 99433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401846A RID: 99434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401846B RID: 99435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401846C RID: 99436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401846D RID: 99437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401846E RID: 99438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401846F RID: 99439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04018470 RID: 99440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04018471 RID: 99441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04018472 RID: 99442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04018473 RID: 99443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04018474 RID: 99444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04018475 RID: 99445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04018476 RID: 99446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04018477 RID: 99447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04018478 RID: 99448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04018479 RID: 99449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401847A RID: 99450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401847B RID: 99451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401847C RID: 99452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401847D RID: 99453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401847E RID: 99454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401847F RID: 99455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04018480 RID: 99456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04018481 RID: 99457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04018482 RID: 99458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04018483 RID: 99459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04018484 RID: 99460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04018485 RID: 99461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04018486 RID: 99462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04018487 RID: 99463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04018488 RID: 99464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04018489 RID: 99465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401848A RID: 99466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401848B RID: 99467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401848C RID: 99468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401848D RID: 99469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401848E RID: 99470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401848F RID: 99471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04018490 RID: 99472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04018491 RID: 99473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04018492 RID: 99474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04018493 RID: 99475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04018494 RID: 99476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04018495 RID: 99477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04018496 RID: 99478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04018497 RID: 99479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04018498 RID: 99480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04018499 RID: 99481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401849A RID: 99482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401849B RID: 99483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401849C RID: 99484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401849D RID: 99485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401849E RID: 99486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401849F RID: 99487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040184A0 RID: 99488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040184A1 RID: 99489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040184A2 RID: 99490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040184A3 RID: 99491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040184A4 RID: 99492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040184A5 RID: 99493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040184A6 RID: 99494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040184A7 RID: 99495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040184A8 RID: 99496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040184A9 RID: 99497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040184AA RID: 99498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040184AB RID: 99499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040184AC RID: 99500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040184AD RID: 99501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040184AE RID: 99502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040184AF RID: 99503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040184B0 RID: 99504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040184B1 RID: 99505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040184B2 RID: 99506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040184B3 RID: 99507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040184B4 RID: 99508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040184B5 RID: 99509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040184B6 RID: 99510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040184B7 RID: 99511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040184B8 RID: 99512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040184B9 RID: 99513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040184BA RID: 99514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040184BB RID: 99515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040184BC RID: 99516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040184BD RID: 99517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040184BE RID: 99518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040184BF RID: 99519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040184C0 RID: 99520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040184C1 RID: 99521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040184C2 RID: 99522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040184C3 RID: 99523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040184C4 RID: 99524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040184C5 RID: 99525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040184C6 RID: 99526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040184C7 RID: 99527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040184C8 RID: 99528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040184C9 RID: 99529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040184CA RID: 99530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040184CB RID: 99531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040184CC RID: 99532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040184CD RID: 99533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040184CE RID: 99534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040184CF RID: 99535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040184D0 RID: 99536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040184D1 RID: 99537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040184D2 RID: 99538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040184D3 RID: 99539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040184D4 RID: 99540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040184D5 RID: 99541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040184D6 RID: 99542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040184D7 RID: 99543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x040184D8 RID: 99544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040184D9 RID: 99545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x040184DA RID: 99546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x040184DB RID: 99547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x040184DC RID: 99548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x040184DD RID: 99549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040184DE RID: 99550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040184DF RID: 99551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040184E0 RID: 99552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040184E1 RID: 99553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040184E2 RID: 99554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040184E3 RID: 99555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040184E4 RID: 99556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040184E5 RID: 99557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040184E6 RID: 99558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040184E7 RID: 99559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040184E8 RID: 99560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040184E9 RID: 99561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040184EA RID: 99562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040184EB RID: 99563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040184EC RID: 99564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040184ED RID: 99565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040184EE RID: 99566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040184EF RID: 99567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040184F0 RID: 99568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040184F1 RID: 99569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040184F2 RID: 99570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040184F3 RID: 99571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040184F4 RID: 99572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040184F5 RID: 99573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040184F6 RID: 99574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040184F7 RID: 99575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040184F8 RID: 99576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040184F9 RID: 99577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040184FA RID: 99578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040184FB RID: 99579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040184FC RID: 99580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040184FD RID: 99581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040184FE RID: 99582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040184FF RID: 99583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04018500 RID: 99584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04018501 RID: 99585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04018502 RID: 99586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04018503 RID: 99587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04018504 RID: 99588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04018505 RID: 99589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04018506 RID: 99590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04018507 RID: 99591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04018508 RID: 99592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04018509 RID: 99593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x0401850A RID: 99594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x0401850B RID: 99595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x0401850C RID: 99596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x0401850D RID: 99597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x0401850E RID: 99598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x0401850F RID: 99599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04018510 RID: 99600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04018511 RID: 99601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04018512 RID: 99602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04018513 RID: 99603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04018514 RID: 99604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04018515 RID: 99605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04018516 RID: 99606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04018517 RID: 99607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04018518 RID: 99608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04018519 RID: 99609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x0401851A RID: 99610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x0401851B RID: 99611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x0401851C RID: 99612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x0401851D RID: 99613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x0401851E RID: 99614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x0401851F RID: 99615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04018520 RID: 99616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04018521 RID: 99617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04018522 RID: 99618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04018523 RID: 99619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04018524 RID: 99620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04018525 RID: 99621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04018526 RID: 99622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04018527 RID: 99623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04018528 RID: 99624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04018529 RID: 99625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x0401852A RID: 99626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x0401852B RID: 99627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x0401852C RID: 99628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x0401852D RID: 99629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x0401852E RID: 99630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x0401852F RID: 99631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x04018530 RID: 99632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x04018531 RID: 99633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x04018532 RID: 99634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x04018533 RID: 99635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x04018534 RID: 99636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x04018535 RID: 99637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x04018536 RID: 99638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x04018537 RID: 99639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x04018538 RID: 99640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04018539 RID: 99641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x0401853A RID: 99642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x0401853B RID: 99643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x0401853C RID: 99644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x0401853D RID: 99645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x0401853E RID: 99646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x0401853F RID: 99647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04018540 RID: 99648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04018541 RID: 99649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04018542 RID: 99650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x04018543 RID: 99651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x04018544 RID: 99652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x04018545 RID: 99653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x04018546 RID: 99654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x04018547 RID: 99655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x04018548 RID: 99656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x04018549 RID: 99657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x0401854A RID: 99658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x0401854B RID: 99659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x0401854C RID: 99660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x0401854D RID: 99661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x0401854E RID: 99662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x0401854F RID: 99663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04018550 RID: 99664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04018551 RID: 99665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04018552 RID: 99666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x04018553 RID: 99667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x04018554 RID: 99668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x04018555 RID: 99669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x04018556 RID: 99670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x04018557 RID: 99671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x04018558 RID: 99672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x04018559 RID: 99673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x0401855A RID: 99674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x0401855B RID: 99675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x0401855C RID: 99676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x0401855D RID: 99677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x0401855E RID: 99678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x0401855F RID: 99679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04018560 RID: 99680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04018561 RID: 99681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04018562 RID: 99682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x04018563 RID: 99683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x04018564 RID: 99684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x04018565 RID: 99685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x04018566 RID: 99686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x04018567 RID: 99687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x04018568 RID: 99688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x04018569 RID: 99689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x0401856A RID: 99690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x0401856B RID: 99691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x0401856C RID: 99692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x0401856D RID: 99693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x0401856E RID: 99694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x0401856F RID: 99695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x04018570 RID: 99696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04018571 RID: 99697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04018572 RID: 99698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x04018573 RID: 99699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x04018574 RID: 99700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x04018575 RID: 99701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x04018576 RID: 99702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x04018577 RID: 99703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x04018578 RID: 99704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x04018579 RID: 99705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x0401857A RID: 99706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x0401857B RID: 99707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x0401857C RID: 99708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x0401857D RID: 99709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x0401857E RID: 99710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x0401857F RID: 99711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;
}
