using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200154E RID: 5454
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RankingUITask : LuaObject
{
	// Token: 0x06020A20 RID: 133664 RVA: 0x00AE79DC File Offset: 0x00AE5BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			RankingUITask o = new RankingUITask(name);
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

	// Token: 0x06020A21 RID: 133665 RVA: 0x00AE7A30 File Offset: 0x00AE5C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareForStartOrResume(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			rankingUITask.PrepareForStartOrResume(intent, onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A22 RID: 133666 RVA: 0x00AE7A94 File Offset: 0x00AE5C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRankingUITask_s(IntPtr l)
	{
		int result;
		try
		{
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 1, out onPrepareEnd);
			UIIntent prevIntent;
			LuaObject.checkType<UIIntent>(l, 2, out prevIntent);
			RankingListType rankingType;
			LuaObject.checkEnum<RankingListType>(l, 3, out rankingType);
			RankingUITask.StartRankingUITask(onPrepareEnd, prevIntent, rankingType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A23 RID: 133667 RVA: 0x00AE7AF8 File Offset: 0x00AE5CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rankingUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020A24 RID: 133668 RVA: 0x00AE7B60 File Offset: 0x00AE5D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rankingUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06020A25 RID: 133669 RVA: 0x00AE7BC8 File Offset: 0x00AE5DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			bool b = rankingUITask.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x06020A26 RID: 133670 RVA: 0x00AE7C24 File Offset: 0x00AE5E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A27 RID: 133671 RVA: 0x00AE7C78 File Offset: 0x00AE5E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			bool b = rankingUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06020A28 RID: 133672 RVA: 0x00AE7CD4 File Offset: 0x00AE5ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			List<string> o = rankingUITask.m_luaExportHelper.CollectAllDynamicResForLoad();
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

	// Token: 0x06020A29 RID: 133673 RVA: 0x00AE7D30 File Offset: 0x00AE5F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A2A RID: 133674 RVA: 0x00AE7D84 File Offset: 0x00AE5F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A2B RID: 133675 RVA: 0x00AE7DD8 File Offset: 0x00AE5FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankingTypeMenuClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			RankingListType rankingType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingType);
			rankingUITask.m_luaExportHelper.OnRankingTypeMenuClick(rankingType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A2C RID: 133676 RVA: 0x00AE7E34 File Offset: 0x00AE6034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResetRankingType(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.OnResetRankingType();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A2D RID: 133677 RVA: 0x00AE7E88 File Offset: 0x00AE6088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A2E RID: 133678 RVA: 0x00AE7EDC File Offset: 0x00AE60DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitPipeLineCtxStateFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			rankingUITask.m_luaExportHelper.InitPipeLineCtxStateFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A2F RID: 133679 RVA: 0x00AE7F38 File Offset: 0x00AE6138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPipelineStateMaskNeedUpdate(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			RankingUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<RankingUITask.PipeLineStateMaskType>(l, 2, out state);
			bool b = rankingUITask.m_luaExportHelper.IsPipelineStateMaskNeedUpdate(state);
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

	// Token: 0x06020A30 RID: 133680 RVA: 0x00AE7FA0 File Offset: 0x00AE61A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnablePipelineStateMask(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			RankingUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<RankingUITask.PipeLineStateMaskType>(l, 2, out state);
			rankingUITask.m_luaExportHelper.EnablePipelineStateMask(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A31 RID: 133681 RVA: 0x00AE7FFC File Offset: 0x00AE61FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rankingUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020A32 RID: 133682 RVA: 0x00AE8064 File Offset: 0x00AE6264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A33 RID: 133683 RVA: 0x00AE80B8 File Offset: 0x00AE62B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A34 RID: 133684 RVA: 0x00AE810C File Offset: 0x00AE630C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rankingUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020A35 RID: 133685 RVA: 0x00AE8174 File Offset: 0x00AE6374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rankingUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020A36 RID: 133686 RVA: 0x00AE81DC File Offset: 0x00AE63DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			rankingUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A37 RID: 133687 RVA: 0x00AE8248 File Offset: 0x00AE6448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			bool b = rankingUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020A38 RID: 133688 RVA: 0x00AE82A4 File Offset: 0x00AE64A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			List<string> o = rankingUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020A39 RID: 133689 RVA: 0x00AE8300 File Offset: 0x00AE6500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A3A RID: 133690 RVA: 0x00AE8354 File Offset: 0x00AE6554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A3B RID: 133691 RVA: 0x00AE83A8 File Offset: 0x00AE65A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A3C RID: 133692 RVA: 0x00AE83FC File Offset: 0x00AE65FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A3D RID: 133693 RVA: 0x00AE8450 File Offset: 0x00AE6650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A3E RID: 133694 RVA: 0x00AE84A4 File Offset: 0x00AE66A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			rankingUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A3F RID: 133695 RVA: 0x00AE8500 File Offset: 0x00AE6700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			rankingUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A40 RID: 133696 RVA: 0x00AE855C File Offset: 0x00AE675C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			rankingUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A41 RID: 133697 RVA: 0x00AE85B8 File Offset: 0x00AE67B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			rankingUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A42 RID: 133698 RVA: 0x00AE8614 File Offset: 0x00AE6814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			bool b = rankingUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020A43 RID: 133699 RVA: 0x00AE8670 File Offset: 0x00AE6870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			bool b = rankingUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020A44 RID: 133700 RVA: 0x00AE86CC File Offset: 0x00AE68CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			bool b = rankingUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020A45 RID: 133701 RVA: 0x00AE8728 File Offset: 0x00AE6928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UITaskBase o = rankingUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06020A46 RID: 133702 RVA: 0x00AE8784 File Offset: 0x00AE6984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A47 RID: 133703 RVA: 0x00AE87D8 File Offset: 0x00AE69D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			rankingUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A48 RID: 133704 RVA: 0x00AE882C File Offset: 0x00AE6A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currRankListType(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rankingUITask.m_luaExportHelper.m_currRankListType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A49 RID: 133705 RVA: 0x00AE8884 File Offset: 0x00AE6A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currRankListType(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			RankingListType currRankListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out currRankListType);
			rankingUITask.m_luaExportHelper.m_currRankListType = currRankListType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A4A RID: 133706 RVA: 0x00AE88E0 File Offset: 0x00AE6AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currRankList(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUITask.m_luaExportHelper.m_currRankList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A4B RID: 133707 RVA: 0x00AE8938 File Offset: 0x00AE6B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currRankList(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			RankingListInfo currRankList;
			LuaObject.checkType<RankingListInfo>(l, 2, out currRankList);
			rankingUITask.m_luaExportHelper.m_currRankList = currRankList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A4C RID: 133708 RVA: 0x00AE8994 File Offset: 0x00AE6B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUITask.m_luaExportHelper.m_mainCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A4D RID: 133709 RVA: 0x00AE89EC File Offset: 0x00AE6BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			RankingUIController mainCtrl;
			LuaObject.checkType<RankingUIController>(l, 2, out mainCtrl);
			rankingUITask.m_luaExportHelper.m_mainCtrl = mainCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A4E RID: 133710 RVA: 0x00AE8A48 File Offset: 0x00AE6C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingListUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUITask.m_luaExportHelper.m_rankingListUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A4F RID: 133711 RVA: 0x00AE8AA0 File Offset: 0x00AE6CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankingListUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			RankingListUIController rankingListUICtrl;
			LuaObject.checkType<RankingListUIController>(l, 2, out rankingListUICtrl);
			rankingUITask.m_luaExportHelper.m_rankingListUICtrl = rankingListUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A50 RID: 133712 RVA: 0x00AE8AFC File Offset: 0x00AE6CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_RankingType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RankingUITask.LuaExportHelper.ParamKey_RankingType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A51 RID: 133713 RVA: 0x00AE8B44 File Offset: 0x00AE6D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ParamKey_RankingType(IntPtr l)
	{
		int result;
		try
		{
			string paramKey_RankingType;
			LuaObject.checkType(l, 2, out paramKey_RankingType);
			RankingUITask.LuaExportHelper.ParamKey_RankingType = paramKey_RankingType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A52 RID: 133714 RVA: 0x00AE8B90 File Offset: 0x00AE6D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A53 RID: 133715 RVA: 0x00AE8BE8 File Offset: 0x00AE6DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			rankingUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A54 RID: 133716 RVA: 0x00AE8C44 File Offset: 0x00AE6E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A55 RID: 133717 RVA: 0x00AE8C9C File Offset: 0x00AE6E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			rankingUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A56 RID: 133718 RVA: 0x00AE8CF8 File Offset: 0x00AE6EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A57 RID: 133719 RVA: 0x00AE8D50 File Offset: 0x00AE6F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RankingUITask rankingUITask = (RankingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A58 RID: 133720 RVA: 0x00AE8DA8 File Offset: 0x00AE6FA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RankingUITask");
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.PrepareForStartOrResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.StartRankingUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.OnRankingTypeMenuClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.OnResetRankingType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.InitPipeLineCtxStateFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.IsPipelineStateMaskNeedUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.EnablePipelineStateMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache26);
		string name = "m_currRankListType";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_m_currRankListType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.set_m_currRankListType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache28, true);
		string name2 = "m_currRankList";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_m_currRankList);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.set_m_currRankList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2A, true);
		string name3 = "m_mainCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_m_mainCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.set_m_mainCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2C, true);
		string name4 = "m_rankingListUICtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_m_rankingListUICtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.set_m_rankingListUICtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2E, true);
		string name5 = "ParamKey_RankingType";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_ParamKey_RankingType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.set_ParamKey_RankingType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache30, false);
		string name6 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_m_layerDescArray);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache32, true);
		string name7 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache34, true);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache35, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache36, null, true);
		if (Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RankingUITask.<>f__mg$cache37, typeof(RankingUITask), typeof(UITask));
	}

	// Token: 0x04016966 RID: 92518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016967 RID: 92519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016968 RID: 92520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016969 RID: 92521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401696A RID: 92522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401696B RID: 92523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401696C RID: 92524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401696D RID: 92525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401696E RID: 92526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401696F RID: 92527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016970 RID: 92528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016971 RID: 92529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016972 RID: 92530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016973 RID: 92531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016974 RID: 92532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016975 RID: 92533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016976 RID: 92534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016977 RID: 92535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016978 RID: 92536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016979 RID: 92537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401697A RID: 92538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401697B RID: 92539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401697C RID: 92540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401697D RID: 92541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401697E RID: 92542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401697F RID: 92543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016980 RID: 92544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016981 RID: 92545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016982 RID: 92546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016983 RID: 92547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016984 RID: 92548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016985 RID: 92549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016986 RID: 92550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016987 RID: 92551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016988 RID: 92552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016989 RID: 92553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401698A RID: 92554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401698B RID: 92555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401698C RID: 92556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401698D RID: 92557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401698E RID: 92558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401698F RID: 92559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016990 RID: 92560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016991 RID: 92561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016992 RID: 92562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016993 RID: 92563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016994 RID: 92564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016995 RID: 92565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016996 RID: 92566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016997 RID: 92567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016998 RID: 92568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016999 RID: 92569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401699A RID: 92570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401699B RID: 92571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401699C RID: 92572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401699D RID: 92573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
