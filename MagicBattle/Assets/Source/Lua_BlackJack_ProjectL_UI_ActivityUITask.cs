using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001358 RID: 4952
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityUITask : LuaObject
{
	// Token: 0x0601AA4F RID: 109135 RVA: 0x007ED494 File Offset: 0x007EB694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ActivityUITask o = new ActivityUITask(name);
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

	// Token: 0x0601AA50 RID: 109136 RVA: 0x007ED4E8 File Offset: 0x007EB6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			bool b = activityUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601AA51 RID: 109137 RVA: 0x007ED544 File Offset: 0x007EB744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectPoolItemsAssets(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			int operationalActivityItemGroupId;
			LuaObject.checkType(l, 2, out operationalActivityItemGroupId);
			activityUITask.m_luaExportHelper.CollectPoolItemsAssets(operationalActivityItemGroupId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA52 RID: 109138 RVA: 0x007ED5A0 File Offset: 0x007EB7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA53 RID: 109139 RVA: 0x007ED5F4 File Offset: 0x007EB7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA54 RID: 109140 RVA: 0x007ED648 File Offset: 0x007EB848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA55 RID: 109141 RVA: 0x007ED69C File Offset: 0x007EB89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUIController_OnGainReward(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			ulong activityInstanceID;
			LuaObject.checkType(l, 2, out activityInstanceID);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 4, out gainGoodsList);
			activityUITask.m_luaExportHelper.ActivityUIController_OnGainReward(activityInstanceID, rewardIndex, gainGoodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA56 RID: 109142 RVA: 0x007ED714 File Offset: 0x007EB914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGainListGoods(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out gainGoodsList);
			IEnumerator gainListGoods = activityUITask.m_luaExportHelper.GetGainListGoods(gainGoodsList);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainListGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA57 RID: 109143 RVA: 0x007ED77C File Offset: 0x007EB97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisposeBoxOpenNetTask(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 2, out type);
			int id;
			LuaObject.checkType(l, 3, out id);
			int count;
			LuaObject.checkType(l, 4, out count);
			IEnumerator o = activityUITask.m_luaExportHelper.DisposeBoxOpenNetTask(type, id, count);
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

	// Token: 0x0601AA58 RID: 109144 RVA: 0x007ED800 File Offset: 0x007EBA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUIController_OnExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			ulong activityInstanceID;
			LuaObject.checkType(l, 2, out activityInstanceID);
			int itemGroupIndex;
			LuaObject.checkType(l, 3, out itemGroupIndex);
			List<Goods> gainGoodsList;
			LuaObject.checkType<List<Goods>>(l, 4, out gainGoodsList);
			activityUITask.m_luaExportHelper.ActivityUIController_OnExchangeItemGroup(activityInstanceID, itemGroupIndex, gainGoodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA59 RID: 109145 RVA: 0x007ED878 File Offset: 0x007EBA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUIController_OnAddActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			string gmCmd;
			LuaObject.checkType(l, 2, out gmCmd);
			activityUITask.m_luaExportHelper.ActivityUIController_OnAddActivity(gmCmd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA5A RID: 109146 RVA: 0x007ED8D4 File Offset: 0x007EBAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.ActivityUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA5B RID: 109147 RVA: 0x007ED928 File Offset: 0x007EBB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUIController_OnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			activityUITask.m_luaExportHelper.ActivityUIController_OnGetRewardButtonClick(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA5C RID: 109148 RVA: 0x007ED984 File Offset: 0x007EBB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUIController_OnGoToButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			activityUITask.m_luaExportHelper.ActivityUIController_OnGoToButtonClick(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA5D RID: 109149 RVA: 0x007ED9E0 File Offset: 0x007EBBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartSelectCardUITask(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 3, out fromIntent);
			activityUITask.m_luaExportHelper.StartSelectCardUITask(cardPoolId, fromIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA5E RID: 109150 RVA: 0x007EDA4C File Offset: 0x007EBC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectCardUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.SelectCardUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA5F RID: 109151 RVA: 0x007EDAA0 File Offset: 0x007EBCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityUIController_OnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.ActivityUIController_OnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA60 RID: 109152 RVA: 0x007EDAF4 File Offset: 0x007EBCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = activityUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601AA61 RID: 109153 RVA: 0x007EDB5C File Offset: 0x007EBD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA62 RID: 109154 RVA: 0x007EDBB0 File Offset: 0x007EBDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA63 RID: 109155 RVA: 0x007EDC04 File Offset: 0x007EBE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = activityUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601AA64 RID: 109156 RVA: 0x007EDC6C File Offset: 0x007EBE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = activityUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601AA65 RID: 109157 RVA: 0x007EDCD4 File Offset: 0x007EBED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			activityUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA66 RID: 109158 RVA: 0x007EDD40 File Offset: 0x007EBF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			bool b = activityUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601AA67 RID: 109159 RVA: 0x007EDD9C File Offset: 0x007EBF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			List<string> o = activityUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601AA68 RID: 109160 RVA: 0x007EDDF8 File Offset: 0x007EBFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA69 RID: 109161 RVA: 0x007EDE4C File Offset: 0x007EC04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA6A RID: 109162 RVA: 0x007EDEA0 File Offset: 0x007EC0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA6B RID: 109163 RVA: 0x007EDEF4 File Offset: 0x007EC0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA6C RID: 109164 RVA: 0x007EDF48 File Offset: 0x007EC148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA6D RID: 109165 RVA: 0x007EDF9C File Offset: 0x007EC19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			activityUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA6E RID: 109166 RVA: 0x007EDFF8 File Offset: 0x007EC1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			activityUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA6F RID: 109167 RVA: 0x007EE054 File Offset: 0x007EC254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			activityUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA70 RID: 109168 RVA: 0x007EE0B0 File Offset: 0x007EC2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			activityUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA71 RID: 109169 RVA: 0x007EE10C File Offset: 0x007EC30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			bool b = activityUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601AA72 RID: 109170 RVA: 0x007EE168 File Offset: 0x007EC368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			bool b = activityUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601AA73 RID: 109171 RVA: 0x007EE1C4 File Offset: 0x007EC3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			bool b = activityUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601AA74 RID: 109172 RVA: 0x007EE220 File Offset: 0x007EC420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			UITaskBase o = activityUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601AA75 RID: 109173 RVA: 0x007EE27C File Offset: 0x007EC47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA76 RID: 109174 RVA: 0x007EE2D0 File Offset: 0x007EC4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			activityUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA77 RID: 109175 RVA: 0x007EE324 File Offset: 0x007EC524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA78 RID: 109176 RVA: 0x007EE37C File Offset: 0x007EC57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			activityUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA79 RID: 109177 RVA: 0x007EE3D8 File Offset: 0x007EC5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA7A RID: 109178 RVA: 0x007EE430 File Offset: 0x007EC630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			activityUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA7B RID: 109179 RVA: 0x007EE48C File Offset: 0x007EC68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA7C RID: 109180 RVA: 0x007EE4E4 File Offset: 0x007EC6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			activityUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA7D RID: 109181 RVA: 0x007EE540 File Offset: 0x007EC740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gainGoodList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUITask.m_luaExportHelper.m_gainGoodList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA7E RID: 109182 RVA: 0x007EE598 File Offset: 0x007EC798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gainGoodList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			List<Goods> gainGoodList;
			LuaObject.checkType<List<Goods>>(l, 2, out gainGoodList);
			activityUITask.m_luaExportHelper.m_gainGoodList = gainGoodList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA7F RID: 109183 RVA: 0x007EE5F4 File Offset: 0x007EC7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityUIController(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUITask.m_luaExportHelper.m_activityUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA80 RID: 109184 RVA: 0x007EE64C File Offset: 0x007EC84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityUIController(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			ActivityUIController activityUIController;
			LuaObject.checkType<ActivityUIController>(l, 2, out activityUIController);
			activityUITask.m_luaExportHelper.m_activityUIController = activityUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA81 RID: 109185 RVA: 0x007EE6A8 File Offset: 0x007EC8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamsKey_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ActivityId");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA82 RID: 109186 RVA: 0x007EE6F0 File Offset: 0x007EC8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA83 RID: 109187 RVA: 0x007EE748 File Offset: 0x007EC948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityUITask activityUITask = (ActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA84 RID: 109188 RVA: 0x007EE7A0 File Offset: 0x007EC9A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityUITask");
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.CollectPoolItemsAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ActivityUIController_OnGainReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.GetGainListGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.DisposeBoxOpenNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ActivityUIController_OnExchangeItemGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ActivityUIController_OnAddActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ActivityUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ActivityUIController_OnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ActivityUIController_OnGoToButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.StartSelectCardUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.SelectCardUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.ActivityUIController_OnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache26);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache28, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2A, true);
		string name3 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_m_configDataLoader);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2C, true);
		string name4 = "m_gainGoodList";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_m_gainGoodList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.set_m_gainGoodList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2E, true);
		string name5 = "m_activityUIController";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_m_activityUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.set_m_activityUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache30, true);
		string name6 = "ParamsKey_ActivityId";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_ParamsKey_ActivityId);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache31, null, false);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache32, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache33, null, true);
		if (Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ActivityUITask.<>f__mg$cache34, typeof(ActivityUITask), typeof(UITask));
	}

	// Token: 0x04010D81 RID: 68993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010D82 RID: 68994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010D83 RID: 68995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010D84 RID: 68996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010D85 RID: 68997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010D86 RID: 68998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010D87 RID: 68999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010D88 RID: 69000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010D89 RID: 69001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010D8A RID: 69002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010D8B RID: 69003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010D8C RID: 69004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010D8D RID: 69005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010D8E RID: 69006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010D8F RID: 69007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010D90 RID: 69008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010D91 RID: 69009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010D92 RID: 69010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010D93 RID: 69011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010D94 RID: 69012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010D95 RID: 69013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010D96 RID: 69014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010D97 RID: 69015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010D98 RID: 69016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010D99 RID: 69017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010D9A RID: 69018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010D9B RID: 69019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010D9C RID: 69020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010D9D RID: 69021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010D9E RID: 69022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010D9F RID: 69023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010DA0 RID: 69024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010DA1 RID: 69025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010DA2 RID: 69026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010DA3 RID: 69027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010DA4 RID: 69028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010DA5 RID: 69029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010DA6 RID: 69030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010DA7 RID: 69031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010DA8 RID: 69032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010DA9 RID: 69033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010DAA RID: 69034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010DAB RID: 69035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010DAC RID: 69036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010DAD RID: 69037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010DAE RID: 69038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010DAF RID: 69039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010DB0 RID: 69040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010DB1 RID: 69041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010DB2 RID: 69042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010DB3 RID: 69043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010DB4 RID: 69044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010DB5 RID: 69045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
