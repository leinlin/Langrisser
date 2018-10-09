using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001516 RID: 5398
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask : LuaObject
{
	// Token: 0x06020006 RID: 131078 RVA: 0x00A96D14 File Offset: 0x00A94F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			MonthCardInfoUITask o = new MonthCardInfoUITask(name);
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

	// Token: 0x06020007 RID: 131079 RVA: 0x00A96D68 File Offset: 0x00A94F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			int cardId;
			LuaObject.checkType(l, 1, out cardId);
			UIIntent returnIntent;
			LuaObject.checkType<UIIntent>(l, 2, out returnIntent);
			MonthCardInfoUITask o = MonthCardInfoUITask.StartUITask(cardId, returnIntent);
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

	// Token: 0x06020008 RID: 131080 RVA: 0x00A96DC8 File Offset: 0x00A94FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = monthCardInfoUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020009 RID: 131081 RVA: 0x00A96E30 File Offset: 0x00A95030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = monthCardInfoUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0602000A RID: 131082 RVA: 0x00A96E98 File Offset: 0x00A95098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			monthCardInfoUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602000B RID: 131083 RVA: 0x00A96EF4 File Offset: 0x00A950F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			List<string> o = monthCardInfoUITask.m_luaExportHelper.CollectAllDynamicResForLoad();
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

	// Token: 0x0602000C RID: 131084 RVA: 0x00A96F50 File Offset: 0x00A95150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			bool b = monthCardInfoUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0602000D RID: 131085 RVA: 0x00A96FAC File Offset: 0x00A951AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602000E RID: 131086 RVA: 0x00A97000 File Offset: 0x00A95200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602000F RID: 131087 RVA: 0x00A97054 File Offset: 0x00A95254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020010 RID: 131088 RVA: 0x00A970A8 File Offset: 0x00A952A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MainCtrlOnClose(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.MainCtrlOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020011 RID: 131089 RVA: 0x00A970FC File Offset: 0x00A952FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = monthCardInfoUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020012 RID: 131090 RVA: 0x00A97164 File Offset: 0x00A95364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020013 RID: 131091 RVA: 0x00A971B8 File Offset: 0x00A953B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020014 RID: 131092 RVA: 0x00A9720C File Offset: 0x00A9540C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = monthCardInfoUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020015 RID: 131093 RVA: 0x00A97274 File Offset: 0x00A95474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = monthCardInfoUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020016 RID: 131094 RVA: 0x00A972DC File Offset: 0x00A954DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			monthCardInfoUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020017 RID: 131095 RVA: 0x00A97348 File Offset: 0x00A95548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			bool b = monthCardInfoUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020018 RID: 131096 RVA: 0x00A973A4 File Offset: 0x00A955A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			List<string> o = monthCardInfoUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020019 RID: 131097 RVA: 0x00A97400 File Offset: 0x00A95600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602001A RID: 131098 RVA: 0x00A97454 File Offset: 0x00A95654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602001B RID: 131099 RVA: 0x00A974A8 File Offset: 0x00A956A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602001C RID: 131100 RVA: 0x00A974FC File Offset: 0x00A956FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602001D RID: 131101 RVA: 0x00A97550 File Offset: 0x00A95750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602001E RID: 131102 RVA: 0x00A975A4 File Offset: 0x00A957A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			monthCardInfoUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602001F RID: 131103 RVA: 0x00A97600 File Offset: 0x00A95800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			monthCardInfoUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020020 RID: 131104 RVA: 0x00A9765C File Offset: 0x00A9585C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			monthCardInfoUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020021 RID: 131105 RVA: 0x00A976B8 File Offset: 0x00A958B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			monthCardInfoUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020022 RID: 131106 RVA: 0x00A97714 File Offset: 0x00A95914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			bool b = monthCardInfoUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020023 RID: 131107 RVA: 0x00A97770 File Offset: 0x00A95970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			bool b = monthCardInfoUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020024 RID: 131108 RVA: 0x00A977CC File Offset: 0x00A959CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			bool b = monthCardInfoUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020025 RID: 131109 RVA: 0x00A97828 File Offset: 0x00A95A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UITaskBase o = monthCardInfoUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06020026 RID: 131110 RVA: 0x00A97884 File Offset: 0x00A95A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020027 RID: 131111 RVA: 0x00A978D8 File Offset: 0x00A95AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020028 RID: 131112 RVA: 0x00A9792C File Offset: 0x00A95B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020029 RID: 131113 RVA: 0x00A97980 File Offset: 0x00A95B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			monthCardInfoUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602002A RID: 131114 RVA: 0x00A979D4 File Offset: 0x00A95BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					monthCardInfoUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					monthCardInfoUITask.EventOnClose -= value;
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

	// Token: 0x0602002B RID: 131115 RVA: 0x00A97A54 File Offset: 0x00A95C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602002C RID: 131116 RVA: 0x00A97AAC File Offset: 0x00A95CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			monthCardInfoUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602002D RID: 131117 RVA: 0x00A97B08 File Offset: 0x00A95D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602002E RID: 131118 RVA: 0x00A97B60 File Offset: 0x00A95D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			monthCardInfoUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602002F RID: 131119 RVA: 0x00A97BBC File Offset: 0x00A95DBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ParamKey_MonthCardId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, MonthCardInfoUITask.LuaExportHelper.ParamKey_MonthCardId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020030 RID: 131120 RVA: 0x00A97C04 File Offset: 0x00A95E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUITask.m_luaExportHelper.m_mainCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020031 RID: 131121 RVA: 0x00A97C5C File Offset: 0x00A95E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			MonthCardInfoUIController mainCtrl;
			LuaObject.checkType<MonthCardInfoUIController>(l, 2, out mainCtrl);
			monthCardInfoUITask.m_luaExportHelper.m_mainCtrl = mainCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020032 RID: 131122 RVA: 0x00A97CB8 File Offset: 0x00A95EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monthCardId(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUITask.m_luaExportHelper.m_monthCardId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020033 RID: 131123 RVA: 0x00A97D10 File Offset: 0x00A95F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_monthCardId(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			monthCardInfoUITask.m_luaExportHelper.m_monthCardId = monthCardId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020034 RID: 131124 RVA: 0x00A97D6C File Offset: 0x00A95F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020035 RID: 131125 RVA: 0x00A97DC4 File Offset: 0x00A95FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUITask monthCardInfoUITask = (MonthCardInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020036 RID: 131126 RVA: 0x00A97E1C File Offset: 0x00A9601C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MonthCardInfoUITask");
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.MainCtrlOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache22);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache23, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache25, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache27, true);
		string name4 = "ParamKey_MonthCardId";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.get_ParamKey_MonthCardId);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache28, null, false);
		string name5 = "m_mainCtrl";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.get_m_mainCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.set_m_mainCtrl);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2A, true);
		string name6 = "m_monthCardId";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.get_m_monthCardId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.set_m_monthCardId);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2C, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2D, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2E, null, true);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.<>f__mg$cache2F, typeof(MonthCardInfoUITask), typeof(UITask));
	}

	// Token: 0x04015FBC RID: 90044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015FBD RID: 90045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015FBE RID: 90046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015FBF RID: 90047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015FC0 RID: 90048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015FC1 RID: 90049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015FC2 RID: 90050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015FC3 RID: 90051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015FC4 RID: 90052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015FC5 RID: 90053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015FC6 RID: 90054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015FC7 RID: 90055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015FC8 RID: 90056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015FC9 RID: 90057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015FCA RID: 90058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015FCB RID: 90059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015FCC RID: 90060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015FCD RID: 90061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015FCE RID: 90062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015FCF RID: 90063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015FD0 RID: 90064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015FD1 RID: 90065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015FD2 RID: 90066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015FD3 RID: 90067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015FD4 RID: 90068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015FD5 RID: 90069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015FD6 RID: 90070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015FD7 RID: 90071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015FD8 RID: 90072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015FD9 RID: 90073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015FDA RID: 90074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015FDB RID: 90075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015FDC RID: 90076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015FDD RID: 90077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015FDE RID: 90078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015FDF RID: 90079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015FE0 RID: 90080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015FE1 RID: 90081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015FE2 RID: 90082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015FE3 RID: 90083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015FE4 RID: 90084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015FE5 RID: 90085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015FE6 RID: 90086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015FE7 RID: 90087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015FE8 RID: 90088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015FE9 RID: 90089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015FEA RID: 90090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015FEB RID: 90091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
