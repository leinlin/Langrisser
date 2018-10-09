using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001569 RID: 5481
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftUITask : LuaObject
{
	// Token: 0x06020D61 RID: 134497 RVA: 0x00B017A0 File Offset: 0x00AFF9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			RiftUITask o = new RiftUITask(name);
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

	// Token: 0x06020D62 RID: 134498 RVA: 0x00B017F4 File Offset: 0x00AFF9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool b = riftUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06020D63 RID: 134499 RVA: 0x00B01850 File Offset: 0x00AFFA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D64 RID: 134500 RVA: 0x00B018A4 File Offset: 0x00AFFAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D65 RID: 134501 RVA: 0x00B018F8 File Offset: 0x00AFFAF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRiftBackgroundUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.InitRiftBackgroundUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D66 RID: 134502 RVA: 0x00B0194C File Offset: 0x00AFFB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D67 RID: 134503 RVA: 0x00B019A0 File Offset: 0x00AFFBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D68 RID: 134504 RVA: 0x00B019F4 File Offset: 0x00AFFBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D69 RID: 134505 RVA: 0x00B01A48 File Offset: 0x00AFFC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerResourceUIController_OnAddGold(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.PlayerResourceUIController_OnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D6A RID: 134506 RVA: 0x00B01A9C File Offset: 0x00AFFC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerResourceUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.PlayerResourceUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D6B RID: 134507 RVA: 0x00B01AF0 File Offset: 0x00AFFCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRiftChapterUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.InitRiftChapterUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D6C RID: 134508 RVA: 0x00B01B44 File Offset: 0x00AFFD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitRiftChapterUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.UninitRiftChapterUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D6D RID: 134509 RVA: 0x00B01B98 File Offset: 0x00AFFD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChapters(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.UpdateChapters();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D6E RID: 134510 RVA: 0x00B01BEC File Offset: 0x00AFFDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChapterProgress(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftUITask.m_luaExportHelper.ShowChapterProgress(chapterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D6F RID: 134511 RVA: 0x00B01C48 File Offset: 0x00AFFE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideChapterProgress(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftUITask.m_luaExportHelper.HideChapterProgress(chapterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D70 RID: 134512 RVA: 0x00B01CA4 File Offset: 0x00AFFEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			bool playOpenAnim;
			LuaObject.checkType(l, 3, out playOpenAnim);
			riftUITask.m_luaExportHelper.SelectChapter(chapterInfo, playOpenAnim);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D71 RID: 134513 RVA: 0x00B01D10 File Offset: 0x00AFFF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftChapterUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.RiftChapterUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D72 RID: 134514 RVA: 0x00B01D64 File Offset: 0x00AFFF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftChapterUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.RiftChapterUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D73 RID: 134515 RVA: 0x00B01DB8 File Offset: 0x00AFFFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftChapterUIController_OnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.RiftChapterUIController_OnReturnToWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D74 RID: 134516 RVA: 0x00B01E0C File Offset: 0x00B0000C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftChapterUIController_OnSelectChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftUITask.m_luaExportHelper.RiftChapterUIController_OnSelectChapter(chapterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D75 RID: 134517 RVA: 0x00B01E68 File Offset: 0x00B00068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftChapterUIController_OnSwitchChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftUITask.m_luaExportHelper.RiftChapterUIController_OnSwitchChapter(chapterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D76 RID: 134518 RVA: 0x00B01EC4 File Offset: 0x00B000C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftChapterUIController_OnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			int scenarioID;
			LuaObject.checkType(l, 2, out scenarioID);
			riftUITask.m_luaExportHelper.RiftChapterUIController_OnGoToScenario(scenarioID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D77 RID: 134519 RVA: 0x00B01F20 File Offset: 0x00B00120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRiftLevelUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.InitRiftLevelUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D78 RID: 134520 RVA: 0x00B01F74 File Offset: 0x00B00174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitRiftLevelUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.UninitRiftLevelUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D79 RID: 134521 RVA: 0x00B01FC8 File Offset: 0x00B001C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRiftLevels(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.UpdateRiftLevels();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D7A RID: 134522 RVA: 0x00B0201C File Offset: 0x00B0021C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStarReward(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftUITask.m_luaExportHelper.UpdateStarReward(chapterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D7B RID: 134523 RVA: 0x00B02078 File Offset: 0x00B00278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.AutoGetStarReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D7C RID: 134524 RVA: 0x00B020CC File Offset: 0x00B002CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckOpenRiftChapterHard(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			bool b = riftUITask.m_luaExportHelper.CheckOpenRiftChapterHard(chapterInfo);
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

	// Token: 0x06020D7D RID: 134525 RVA: 0x00B02134 File Offset: 0x00B00334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			riftUITask.m_luaExportHelper.StartBattleLevelInfoUITask(riftLevelInfo, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D7E RID: 134526 RVA: 0x00B021A0 File Offset: 0x00B003A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftLevelUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.RiftLevelUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D7F RID: 134527 RVA: 0x00B021F4 File Offset: 0x00B003F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftLevelUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.RiftLevelUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D80 RID: 134528 RVA: 0x00B02248 File Offset: 0x00B00448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftLevelUIController_OnReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.RiftLevelUIController_OnReturnToWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D81 RID: 134529 RVA: 0x00B0229C File Offset: 0x00B0049C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftLevelUIController_OnChangeHard(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.RiftLevelUIController_OnChangeHard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D82 RID: 134530 RVA: 0x00B022F0 File Offset: 0x00B004F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftLevelUIController_OnSelectRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			riftUITask.m_luaExportHelper.RiftLevelUIController_OnSelectRiftLevel(riftLevelInfo, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D83 RID: 134531 RVA: 0x00B0235C File Offset: 0x00B0055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftLevelUIController_OnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			riftUITask.m_luaExportHelper.RiftLevelUIController_OnGetStarReward(idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D84 RID: 134532 RVA: 0x00B023B8 File Offset: 0x00B005B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RiftLevelUIController_OnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			int scenarioID;
			LuaObject.checkType(l, 2, out scenarioID);
			riftUITask.m_luaExportHelper.RiftLevelUIController_OnGoToScenario(scenarioID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D85 RID: 134533 RVA: 0x00B02414 File Offset: 0x00B00614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChestUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			riftUITask.m_luaExportHelper.ChestUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D86 RID: 134534 RVA: 0x00B02470 File Offset: 0x00B00670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChestUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.ChestUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D87 RID: 134535 RVA: 0x00B024C4 File Offset: 0x00B006C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.BattleLevelInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D88 RID: 134536 RVA: 0x00B02518 File Offset: 0x00B00718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUITask_OnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			riftUITask.m_luaExportHelper.BattleLevelInfoUITask_OnRiftRaidComplete(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D89 RID: 134537 RVA: 0x00B02574 File Offset: 0x00B00774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = riftUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020D8A RID: 134538 RVA: 0x00B025DC File Offset: 0x00B007DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D8B RID: 134539 RVA: 0x00B02630 File Offset: 0x00B00830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D8C RID: 134540 RVA: 0x00B02684 File Offset: 0x00B00884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = riftUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020D8D RID: 134541 RVA: 0x00B026EC File Offset: 0x00B008EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = riftUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020D8E RID: 134542 RVA: 0x00B02754 File Offset: 0x00B00954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			riftUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D8F RID: 134543 RVA: 0x00B027C0 File Offset: 0x00B009C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool b = riftUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020D90 RID: 134544 RVA: 0x00B0281C File Offset: 0x00B00A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			List<string> o = riftUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020D91 RID: 134545 RVA: 0x00B02878 File Offset: 0x00B00A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D92 RID: 134546 RVA: 0x00B028CC File Offset: 0x00B00ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D93 RID: 134547 RVA: 0x00B02920 File Offset: 0x00B00B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D94 RID: 134548 RVA: 0x00B02974 File Offset: 0x00B00B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D95 RID: 134549 RVA: 0x00B029C8 File Offset: 0x00B00BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D96 RID: 134550 RVA: 0x00B02A1C File Offset: 0x00B00C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			riftUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D97 RID: 134551 RVA: 0x00B02A78 File Offset: 0x00B00C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			riftUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D98 RID: 134552 RVA: 0x00B02AD4 File Offset: 0x00B00CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			riftUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D99 RID: 134553 RVA: 0x00B02B30 File Offset: 0x00B00D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			riftUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D9A RID: 134554 RVA: 0x00B02B8C File Offset: 0x00B00D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool b = riftUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020D9B RID: 134555 RVA: 0x00B02BE8 File Offset: 0x00B00DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool b = riftUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020D9C RID: 134556 RVA: 0x00B02C44 File Offset: 0x00B00E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool b = riftUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020D9D RID: 134557 RVA: 0x00B02CA0 File Offset: 0x00B00EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			UITaskBase o = riftUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06020D9E RID: 134558 RVA: 0x00B02CFC File Offset: 0x00B00EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D9F RID: 134559 RVA: 0x00B02D50 File Offset: 0x00B00F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			riftUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA0 RID: 134560 RVA: 0x00B02DA4 File Offset: 0x00B00FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftUITask.m_luaExportHelper.__callDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA1 RID: 134561 RVA: 0x00B02E00 File Offset: 0x00B01000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftUITask.m_luaExportHelper.__clearDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA2 RID: 134562 RVA: 0x00B02E5C File Offset: 0x00B0105C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA3 RID: 134563 RVA: 0x00B02EB4 File Offset: 0x00B010B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			riftUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA4 RID: 134564 RVA: 0x00B02F10 File Offset: 0x00B01110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA5 RID: 134565 RVA: 0x00B02F68 File Offset: 0x00B01168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			riftUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA6 RID: 134566 RVA: 0x00B02FC4 File Offset: 0x00B011C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftBackgroundUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_riftBackgroundUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA7 RID: 134567 RVA: 0x00B0301C File Offset: 0x00B0121C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftBackgroundUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			RiftBackgroundUIController riftBackgroundUIController;
			LuaObject.checkType<RiftBackgroundUIController>(l, 2, out riftBackgroundUIController);
			riftUITask.m_luaExportHelper.m_riftBackgroundUIController = riftBackgroundUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA8 RID: 134568 RVA: 0x00B03078 File Offset: 0x00B01278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftChapterUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_riftChapterUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DA9 RID: 134569 RVA: 0x00B030D0 File Offset: 0x00B012D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftChapterUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			RiftChapterUIController riftChapterUIController;
			LuaObject.checkType<RiftChapterUIController>(l, 2, out riftChapterUIController);
			riftUITask.m_luaExportHelper.m_riftChapterUIController = riftChapterUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DAA RID: 134570 RVA: 0x00B0312C File Offset: 0x00B0132C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_riftLevelUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DAB RID: 134571 RVA: 0x00B03184 File Offset: 0x00B01384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			RiftLevelUIController riftLevelUIController;
			LuaObject.checkType<RiftLevelUIController>(l, 2, out riftLevelUIController);
			riftUITask.m_luaExportHelper.m_riftLevelUIController = riftLevelUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DAC RID: 134572 RVA: 0x00B031E0 File Offset: 0x00B013E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftChapterPlayerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_riftChapterPlayerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DAD RID: 134573 RVA: 0x00B03238 File Offset: 0x00B01438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftChapterPlayerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController riftChapterPlayerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out riftChapterPlayerResourceUIController);
			riftUITask.m_luaExportHelper.m_riftChapterPlayerResourceUIController = riftChapterPlayerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DAE RID: 134574 RVA: 0x00B03294 File Offset: 0x00B01494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelPlayerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_riftLevelPlayerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DAF RID: 134575 RVA: 0x00B032EC File Offset: 0x00B014EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelPlayerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController riftLevelPlayerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out riftLevelPlayerResourceUIController);
			riftUITask.m_luaExportHelper.m_riftLevelPlayerResourceUIController = riftLevelPlayerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB0 RID: 134576 RVA: 0x00B03348 File Offset: 0x00B01548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_chapterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB1 RID: 134577 RVA: 0x00B033A0 File Offset: 0x00B015A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftUITask.m_luaExportHelper.m_chapterInfo = chapterInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB2 RID: 134578 RVA: 0x00B033FC File Offset: 0x00B015FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needReturnToChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_needReturnToChapter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB3 RID: 134579 RVA: 0x00B03454 File Offset: 0x00B01654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needReturnToChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool needReturnToChapter;
			LuaObject.checkType(l, 2, out needReturnToChapter);
			riftUITask.m_luaExportHelper.m_needReturnToChapter = needReturnToChapter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB4 RID: 134580 RVA: 0x00B034B0 File Offset: 0x00B016B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needPlayRiftLevelOpenAnimation(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_needPlayRiftLevelOpenAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB5 RID: 134581 RVA: 0x00B03508 File Offset: 0x00B01708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needPlayRiftLevelOpenAnimation(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			bool needPlayRiftLevelOpenAnimation;
			LuaObject.checkType(l, 2, out needPlayRiftLevelOpenAnimation);
			riftUITask.m_luaExportHelper.m_needPlayRiftLevelOpenAnimation = needPlayRiftLevelOpenAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB6 RID: 134582 RVA: 0x00B03564 File Offset: 0x00B01764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_battleLevelInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB7 RID: 134583 RVA: 0x00B035BC File Offset: 0x00B017BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			BattleLevelInfoUITask battleLevelInfoUITask;
			LuaObject.checkType<BattleLevelInfoUITask>(l, 2, out battleLevelInfoUITask);
			riftUITask.m_luaExportHelper.m_battleLevelInfoUITask = battleLevelInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB8 RID: 134584 RVA: 0x00B03618 File Offset: 0x00B01818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.m_chestUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DB9 RID: 134585 RVA: 0x00B03670 File Offset: 0x00B01870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			ChestUITask chestUITask;
			LuaObject.checkType<ChestUITask>(l, 2, out chestUITask);
			riftUITask.m_luaExportHelper.m_chestUITask = chestUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DBA RID: 134586 RVA: 0x00B036CC File Offset: 0x00B018CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_viewState(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)riftUITask.m_luaExportHelper.m_viewState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DBB RID: 134587 RVA: 0x00B03724 File Offset: 0x00B01924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_viewState(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			RiftUITask.ViewState viewState;
			LuaObject.checkEnum<RiftUITask.ViewState>(l, 2, out viewState);
			riftUITask.m_luaExportHelper.m_viewState = viewState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DBC RID: 134588 RVA: 0x00B03780 File Offset: 0x00B01980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftUITask.EventOnGoToScenario += value;
				}
				else if (num == 2)
				{
					riftUITask.EventOnGoToScenario -= value;
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

	// Token: 0x06020DBD RID: 134589 RVA: 0x00B03800 File Offset: 0x00B01A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DBE RID: 134590 RVA: 0x00B03858 File Offset: 0x00B01A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RiftUITask riftUITask = (RiftUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DBF RID: 134591 RVA: 0x00B038B0 File Offset: 0x00B01AB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftUITask");
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.InitRiftBackgroundUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.PlayerResourceUIController_OnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.PlayerResourceUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.InitRiftChapterUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.UninitRiftChapterUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.UpdateChapters);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.ShowChapterProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.HideChapterProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.SelectChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftChapterUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftChapterUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftChapterUIController_OnReturnToWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftChapterUIController_OnSelectChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftChapterUIController_OnSwitchChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftChapterUIController_OnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.InitRiftLevelUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.UninitRiftLevelUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.UpdateRiftLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.UpdateStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.AutoGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.CheckOpenRiftChapterHard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.StartBattleLevelInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftLevelUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftLevelUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftLevelUIController_OnReturnToWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftLevelUIController_OnChangeHard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftLevelUIController_OnSelectRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftLevelUIController_OnGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.RiftLevelUIController_OnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.ChestUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.ChestUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.BattleLevelInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.BattleLevelInfoUITask_OnRiftRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__callDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.__clearDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache3F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache41, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache43, true);
		string name3 = "m_riftBackgroundUIController";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_riftBackgroundUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_riftBackgroundUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache45, true);
		string name4 = "m_riftChapterUIController";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_riftChapterUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_riftChapterUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache47, true);
		string name5 = "m_riftLevelUIController";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_riftLevelUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_riftLevelUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache49, true);
		string name6 = "m_riftChapterPlayerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_riftChapterPlayerResourceUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_riftChapterPlayerResourceUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4B, true);
		string name7 = "m_riftLevelPlayerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_riftLevelPlayerResourceUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_riftLevelPlayerResourceUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4D, true);
		string name8 = "m_chapterInfo";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_chapterInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_chapterInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache4F, true);
		string name9 = "m_needReturnToChapter";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_needReturnToChapter);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_needReturnToChapter);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache51, true);
		string name10 = "m_needPlayRiftLevelOpenAnimation";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_needPlayRiftLevelOpenAnimation);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_needPlayRiftLevelOpenAnimation);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache53, true);
		string name11 = "m_battleLevelInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_battleLevelInfoUITask);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_battleLevelInfoUITask);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache55, true);
		string name12 = "m_chestUITask";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_chestUITask);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_chestUITask);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache57, true);
		string name13 = "m_viewState";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_m_viewState);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_m_viewState);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache59, true);
		string name14 = "EventOnGoToScenario";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.set_EventOnGoToScenario);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5A, true);
		string name15 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5B, null, true);
		string name16 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5C, null, true);
		if (Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RiftUITask.<>f__mg$cache5D, typeof(RiftUITask), typeof(UITask));
	}

	// Token: 0x04016C71 RID: 93297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016C72 RID: 93298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016C73 RID: 93299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016C74 RID: 93300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016C75 RID: 93301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016C76 RID: 93302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016C77 RID: 93303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016C78 RID: 93304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016C79 RID: 93305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016C7A RID: 93306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016C7B RID: 93307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016C7C RID: 93308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016C7D RID: 93309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016C7E RID: 93310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016C7F RID: 93311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016C80 RID: 93312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016C81 RID: 93313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016C82 RID: 93314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016C83 RID: 93315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016C84 RID: 93316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016C85 RID: 93317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016C86 RID: 93318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016C87 RID: 93319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016C88 RID: 93320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016C89 RID: 93321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016C8A RID: 93322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016C8B RID: 93323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016C8C RID: 93324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016C8D RID: 93325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016C8E RID: 93326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016C8F RID: 93327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016C90 RID: 93328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016C91 RID: 93329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016C92 RID: 93330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016C93 RID: 93331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016C94 RID: 93332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016C95 RID: 93333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016C96 RID: 93334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016C97 RID: 93335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016C98 RID: 93336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016C99 RID: 93337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016C9A RID: 93338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016C9B RID: 93339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016C9C RID: 93340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016C9D RID: 93341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016C9E RID: 93342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016C9F RID: 93343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016CA0 RID: 93344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016CA1 RID: 93345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016CA2 RID: 93346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016CA3 RID: 93347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016CA4 RID: 93348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016CA5 RID: 93349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016CA6 RID: 93350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016CA7 RID: 93351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016CA8 RID: 93352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016CA9 RID: 93353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016CAA RID: 93354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016CAB RID: 93355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016CAC RID: 93356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016CAD RID: 93357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016CAE RID: 93358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016CAF RID: 93359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016CB0 RID: 93360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016CB1 RID: 93361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016CB2 RID: 93362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016CB3 RID: 93363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016CB4 RID: 93364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04016CB5 RID: 93365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04016CB6 RID: 93366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04016CB7 RID: 93367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04016CB8 RID: 93368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04016CB9 RID: 93369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016CBA RID: 93370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016CBB RID: 93371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016CBC RID: 93372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016CBD RID: 93373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016CBE RID: 93374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016CBF RID: 93375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016CC0 RID: 93376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016CC1 RID: 93377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016CC2 RID: 93378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016CC3 RID: 93379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04016CC4 RID: 93380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04016CC5 RID: 93381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04016CC6 RID: 93382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04016CC7 RID: 93383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04016CC8 RID: 93384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04016CC9 RID: 93385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04016CCA RID: 93386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04016CCB RID: 93387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04016CCC RID: 93388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04016CCD RID: 93389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04016CCE RID: 93390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;
}
