using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001570 RID: 5488
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SelectCardUITask : LuaObject
{
	// Token: 0x06020F93 RID: 135059 RVA: 0x00B12EAC File Offset: 0x00B110AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			SelectCardUITask o = new SelectCardUITask(name);
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

	// Token: 0x06020F94 RID: 135060 RVA: 0x00B12F00 File Offset: 0x00B11100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F95 RID: 135061 RVA: 0x00B12F54 File Offset: 0x00B11154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F96 RID: 135062 RVA: 0x00B12FA8 File Offset: 0x00B111A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F97 RID: 135063 RVA: 0x00B12FFC File Offset: 0x00B111FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool b = selectCardUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06020F98 RID: 135064 RVA: 0x00B13058 File Offset: 0x00B11258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F99 RID: 135065 RVA: 0x00B130AC File Offset: 0x00B112AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F9A RID: 135066 RVA: 0x00B13100 File Offset: 0x00B11300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F9B RID: 135067 RVA: 0x00B13154 File Offset: 0x00B11354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnArvhive(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnArvhive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F9C RID: 135068 RVA: 0x00B131A8 File Offset: 0x00B113A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnShowSelectCardHelp(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnShowSelectCardHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F9D RID: 135069 RVA: 0x00B131FC File Offset: 0x00B113FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnShowActivityDetail(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			CardPool pool;
			LuaObject.checkType<CardPool>(l, 2, out pool);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnShowActivityDetail(pool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F9E RID: 135070 RVA: 0x00B13258 File Offset: 0x00B11458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnBagCapcityNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnBagCapcityNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F9F RID: 135071 RVA: 0x00B132AC File Offset: 0x00B114AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FA0 RID: 135072 RVA: 0x00B13300 File Offset: 0x00B11500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FA1 RID: 135073 RVA: 0x00B13354 File Offset: 0x00B11554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUIController_OnCardSelect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			bool isSingleSlect;
			LuaObject.checkType(l, 3, out isSingleSlect);
			selectCardUITask.m_luaExportHelper.SelectCardUIController_OnCardSelect(cardPoolId, isSingleSlect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FA2 RID: 135074 RVA: 0x00B133C0 File Offset: 0x00B115C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeiBoShareTenClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.OnWeiBoShareTenClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FA3 RID: 135075 RVA: 0x00B13414 File Offset: 0x00B11614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeChatShareTenClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.OnWeChatShareTenClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FA4 RID: 135076 RVA: 0x00B13468 File Offset: 0x00B11668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = selectCardUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020FA5 RID: 135077 RVA: 0x00B134D0 File Offset: 0x00B116D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FA6 RID: 135078 RVA: 0x00B13524 File Offset: 0x00B11724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FA7 RID: 135079 RVA: 0x00B13578 File Offset: 0x00B11778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = selectCardUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020FA8 RID: 135080 RVA: 0x00B135E0 File Offset: 0x00B117E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = selectCardUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020FA9 RID: 135081 RVA: 0x00B13648 File Offset: 0x00B11848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			selectCardUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FAA RID: 135082 RVA: 0x00B136B4 File Offset: 0x00B118B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool b = selectCardUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020FAB RID: 135083 RVA: 0x00B13710 File Offset: 0x00B11910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			List<string> o = selectCardUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020FAC RID: 135084 RVA: 0x00B1376C File Offset: 0x00B1196C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FAD RID: 135085 RVA: 0x00B137C0 File Offset: 0x00B119C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FAE RID: 135086 RVA: 0x00B13814 File Offset: 0x00B11A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FAF RID: 135087 RVA: 0x00B13868 File Offset: 0x00B11A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FB0 RID: 135088 RVA: 0x00B138BC File Offset: 0x00B11ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FB1 RID: 135089 RVA: 0x00B13910 File Offset: 0x00B11B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			selectCardUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FB2 RID: 135090 RVA: 0x00B1396C File Offset: 0x00B11B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			selectCardUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FB3 RID: 135091 RVA: 0x00B139C8 File Offset: 0x00B11BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			selectCardUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FB4 RID: 135092 RVA: 0x00B13A24 File Offset: 0x00B11C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			selectCardUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FB5 RID: 135093 RVA: 0x00B13A80 File Offset: 0x00B11C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool b = selectCardUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020FB6 RID: 135094 RVA: 0x00B13ADC File Offset: 0x00B11CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool b = selectCardUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020FB7 RID: 135095 RVA: 0x00B13B38 File Offset: 0x00B11D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool b = selectCardUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020FB8 RID: 135096 RVA: 0x00B13B94 File Offset: 0x00B11D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			UITaskBase o = selectCardUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06020FB9 RID: 135097 RVA: 0x00B13BF0 File Offset: 0x00B11DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FBA RID: 135098 RVA: 0x00B13C44 File Offset: 0x00B11E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			selectCardUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FBB RID: 135099 RVA: 0x00B13C98 File Offset: 0x00B11E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FBC RID: 135100 RVA: 0x00B13CF0 File Offset: 0x00B11EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			selectCardUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FBD RID: 135101 RVA: 0x00B13D4C File Offset: 0x00B11F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FBE RID: 135102 RVA: 0x00B13DA4 File Offset: 0x00B11FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			selectCardUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FBF RID: 135103 RVA: 0x00B13E00 File Offset: 0x00B12000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIdList(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_heroIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC0 RID: 135104 RVA: 0x00B13E58 File Offset: 0x00B12058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIdList(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			List<int> heroIdList;
			LuaObject.checkType<List<int>>(l, 2, out heroIdList);
			selectCardUITask.m_luaExportHelper.m_heroIdList = heroIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC1 RID: 135105 RVA: 0x00B13EB4 File Offset: 0x00B120B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewards(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC2 RID: 135106 RVA: 0x00B13F0C File Offset: 0x00B1210C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewards(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			selectCardUITask.m_luaExportHelper.m_rewards = rewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC3 RID: 135107 RVA: 0x00B13F68 File Offset: 0x00B12168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowRewardsPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_isShowRewardsPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC4 RID: 135108 RVA: 0x00B13FC0 File Offset: 0x00B121C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowRewardsPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool isShowRewardsPanel;
			LuaObject.checkType(l, 2, out isShowRewardsPanel);
			selectCardUITask.m_luaExportHelper.m_isShowRewardsPanel = isShowRewardsPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC5 RID: 135109 RVA: 0x00B1401C File Offset: 0x00B1221C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isRefresShareTenPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_isRefresShareTenPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC6 RID: 135110 RVA: 0x00B14074 File Offset: 0x00B12274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRefresShareTenPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			bool isRefresShareTenPanel;
			LuaObject.checkType(l, 2, out isRefresShareTenPanel);
			selectCardUITask.m_luaExportHelper.m_isRefresShareTenPanel = isRefresShareTenPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC7 RID: 135111 RVA: 0x00B140D0 File Offset: 0x00B122D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectCardUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_selectCardUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC8 RID: 135112 RVA: 0x00B14128 File Offset: 0x00B12328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectCardUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			SelectCardUIController selectCardUIController;
			LuaObject.checkType<SelectCardUIController>(l, 2, out selectCardUIController);
			selectCardUITask.m_luaExportHelper.m_selectCardUIController = selectCardUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FC9 RID: 135113 RVA: 0x00B14184 File Offset: 0x00B12384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectCardBackground3DController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_selectCardBackground3DController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FCA RID: 135114 RVA: 0x00B141DC File Offset: 0x00B123DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectCardBackground3DController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			SelectCardBackground3DController selectCardBackground3DController;
			LuaObject.checkType<SelectCardBackground3DController>(l, 2, out selectCardBackground3DController);
			selectCardUITask.m_luaExportHelper.m_selectCardBackground3DController = selectCardBackground3DController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FCB RID: 135115 RVA: 0x00B14238 File Offset: 0x00B12438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareTenSelectCardUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.m_shareTenSelectCardUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FCC RID: 135116 RVA: 0x00B14290 File Offset: 0x00B12490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareTenSelectCardUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			ShareTenSelectCardUIController shareTenSelectCardUIController;
			LuaObject.checkType<ShareTenSelectCardUIController>(l, 2, out shareTenSelectCardUIController);
			selectCardUITask.m_luaExportHelper.m_shareTenSelectCardUIController = shareTenSelectCardUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FCD RID: 135117 RVA: 0x00B142EC File Offset: 0x00B124EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FCE RID: 135118 RVA: 0x00B14344 File Offset: 0x00B12544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUITask selectCardUITask = (SelectCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FCF RID: 135119 RVA: 0x00B1439C File Offset: 0x00B1259C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SelectCardUITask");
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnArvhive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnShowSelectCardHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnShowActivityDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnBagCapcityNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.SelectCardUIController_OnCardSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.OnWeiBoShareTenClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.OnWeChatShareTenClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache26);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache28, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2A, true);
		string name3 = "m_heroIdList";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_heroIdList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_heroIdList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2C, true);
		string name4 = "m_rewards";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_rewards);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_rewards);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2E, true);
		string name5 = "m_isShowRewardsPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_isShowRewardsPanel);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_isShowRewardsPanel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache30, true);
		string name6 = "m_isRefresShareTenPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_isRefresShareTenPanel);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_isRefresShareTenPanel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache32, true);
		string name7 = "m_selectCardUIController";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_selectCardUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_selectCardUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache34, true);
		string name8 = "m_selectCardBackground3DController";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_selectCardBackground3DController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_selectCardBackground3DController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache36, true);
		string name9 = "m_shareTenSelectCardUIController";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_m_shareTenSelectCardUIController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.set_m_shareTenSelectCardUIController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache38, true);
		string name10 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache39, null, true);
		string name11 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3A, null, true);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SelectCardUITask.<>f__mg$cache3B, typeof(SelectCardUITask), typeof(UITask));
	}

	// Token: 0x04016E95 RID: 93845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016E96 RID: 93846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016E97 RID: 93847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016E98 RID: 93848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016E99 RID: 93849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016E9A RID: 93850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016E9B RID: 93851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016E9C RID: 93852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016E9D RID: 93853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016E9E RID: 93854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016E9F RID: 93855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016EA0 RID: 93856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016EA1 RID: 93857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016EA2 RID: 93858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016EA3 RID: 93859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016EA4 RID: 93860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016EA5 RID: 93861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016EA6 RID: 93862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016EA7 RID: 93863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016EA8 RID: 93864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016EA9 RID: 93865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016EAA RID: 93866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016EAB RID: 93867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016EAC RID: 93868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016EAD RID: 93869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016EAE RID: 93870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016EAF RID: 93871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016EB0 RID: 93872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016EB1 RID: 93873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016EB2 RID: 93874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016EB3 RID: 93875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016EB4 RID: 93876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016EB5 RID: 93877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016EB6 RID: 93878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016EB7 RID: 93879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016EB8 RID: 93880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016EB9 RID: 93881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016EBA RID: 93882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016EBB RID: 93883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016EBC RID: 93884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016EBD RID: 93885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016EBE RID: 93886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016EBF RID: 93887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016EC0 RID: 93888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016EC1 RID: 93889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016EC2 RID: 93890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016EC3 RID: 93891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016EC4 RID: 93892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016EC5 RID: 93893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016EC6 RID: 93894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016EC7 RID: 93895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016EC8 RID: 93896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016EC9 RID: 93897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016ECA RID: 93898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016ECB RID: 93899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016ECC RID: 93900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016ECD RID: 93901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016ECE RID: 93902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016ECF RID: 93903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016ED0 RID: 93904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
